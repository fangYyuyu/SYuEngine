   M S B A M L   `   `   `  ����D  @SYuEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SYuEditor.GameProjectSYuEditor.GameProject  5      *    $SYuEditor.GameProject.NewProjectView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SYuEditor.GameProject     5      $	��800��5        � DataContext  5      &   SYuEditor.GameProject.NewProject  5   
   .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5         ��Name$ templateListBox��5      $	��160��6/   $	��250��6;    �� SelectedIndex$ 0��5      ��6'   �� *ProjectTemples+��5      �� 5      .R�5      �� $ 
Horizontal=�6%   .+�5      �� $��0,5,5,0q�6<   ��6$   �� *Icon+6<   �� 5      ��6(   �� *ProjectType+5      5      5      �� 5      $	��450��6   $	��250��6!   $��5,0,0,0q�6.   ��5      �� 5       �� ImageSource 6!   ��  �� Path$ SelectedItem.Screenshot� �� ElementName$ templateListBox��5       5!      �� 5"   
   $ 
Horizontal=�6   $��Center=�6.   $��0,20,0,0q�5#      .+�5$      �� $
��Name��6   $��50��6$   �� 5%      $	��565��6   ��6"   �� *ProjectName+5&      �� 5'   
   $ 
Horizontal=�6   $��Center=�6.   $��0,5,0,0q�5(      .+�5)      �� $
��Path��6   $��50��6$   �� 5*      $	��500��6   ��6"   �� *ProjectPath+�� 5+      $��Browser��6   $��10,0,0,0q�6'   5,      �� 5.   
   $ 
Horizontal=�6   $��Center=�6.   $��0,20,0,0q�5/      .+�50      �� $��Create��6   $	��100��6&   �� 51      $
��Exit��6   $	��100��6$   $��20,0,0,0q�60    �� IsCancel$
 True��6B   52      53      54      