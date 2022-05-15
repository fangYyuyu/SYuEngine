using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using SYuEditor.Utilities;

namespace SYuEditor.GameProject
{
    [DataContract]
    public class ProjectTemple
    {
        [DataMember]
        public string ProjectType { get; set; }
        [DataMember]
        public string ProjectFile { get; set; }
        [DataMember]
        public List<string> Folders { get; set; }
        public byte[] Icon { get; set; }
        public byte[] Screenshot { get; set; }
        public string IconFilePath { get; set; }
        public string ScreenshotPath { get; set; }
        public string ProjectFilePath { get; set; }

    }
    class NewProject : ViewModelBase
    {
        private readonly string _templatePath = @"..\..\SYuEditor\ProjectTemplates";

        private string _projectName = "NewProject";
        public string ProjectName
        {
            get => _projectName;
            set {
                if (_projectName != value)
                {
                    _projectName = value;
                    OnPropertyChanged(nameof(ProjectName));
                }
            }
        }
        private string _projectPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";
        public string ProjectPath
        {
            get => _projectPath;
            set
            {
                if (_projectPath != value)
                {
                    _projectPath = value;
                    OnPropertyChanged(nameof(ProjectPath));
                }
            }
        }

        private ObservableCollection<ProjectTemple> _projectTemples = new ObservableCollection<ProjectTemple>();
        public ReadOnlyObservableCollection<ProjectTemple> ProjectTemples
        {
            get;
        }
        
        public NewProject()
        {
            ProjectTemples = new ReadOnlyObservableCollection<ProjectTemple>(_projectTemples);
            try
            {
                var templatesFiles = Directory.GetFiles(@"C:\Users\yuyu\source\repos\SShen\SYuEditor\ProjectTemplates", "Templates.xml", SearchOption.AllDirectories);
                Debug.Assert(templatesFiles.Any());
                foreach(var file in templatesFiles)
                {
                  var template =  Serializer.FromFile<ProjectTemple>(file);
                    template.IconFilePath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(file), "icon.png"));
                    template.Icon = File.ReadAllBytes(template.IconFilePath);
                    template.ScreenshotPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(file), "Screenshot.png"));
                    template.Screenshot = File.ReadAllBytes(template.ScreenshotPath);
                    template.ProjectFilePath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(file), template.ProjectFile));
                    _projectTemples.Add(template);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
           
        }




    }


}
