   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   O KWpfViewModelExercice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfViewModelExerciceWpfViewModelExercice 5   	   %   WpfViewModelExercice.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   4local"clr-namespace:WpfViewModelExercice     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   
����ح�.��5
      � -   5        $��Ctrl_Grd_View��5
      ��5      �� *MainBackgroundColor+ � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��Ctrl_Tbk_Atxt��5      $
��A : ��5       �� TextAlignment$ Right=�5      $��0��5      $��0��5      $	��100��5      $��25��5      �� 5   
   -   5        $��
Ctrl_Tbx_A��5       �� TextAlignment$
 Left=�5       $��0��5!      $��1��5"      $	��100��5#      $��25��5$      ��5      �� *DataA+ �� UpdateSourceTrigger$ PropertyChanged=� �� FallbackValue$ 0����5      �� *NotificationColorA+.��5$      .   (System.Windows.Interactivity.Interaction   Triggers 5%      /   )System.Windows.Interactivity.EventTrigger  5&         	EventName$ 
MouseEnter��6!   .   (System.Windows.Interactivity.TriggerBase	   Actions.	 5'      6   0System.Windows.Interactivity.InvokeCommandAction  
   Command
 6,   �� *MouseEnterTbxACommand+5(        5)      $ MousseLeave��6!   .	 5*        
 6,   �� *MouseLeaveTbxCommand+5+      .��5,   &   5-      �� 5/   
   -   5        $��Ctrl_Tbk_Btxt��5/      $
��B : ��50      $ Right=�51      $��1��52      $��0��53      $	��100��54      $��25��55      �� 56   
   -   5        $��
Ctrl_Tbx_B��58      $��1��59      $��1��5:      $
 Left=�5;      $	��100��5<      $��25��5=      ��56      �� *DataB+$ PropertyChanged=�$ 0����57      �� *NotificationColorB+$ White��.��5=       5>        5?      $ 
MouseEnter��6!   .	 5@        
 6,   �� *MouseEnterTbxBCommand+5A        5B      $ MousseLeave��6!   .	 5C        
 6,   �� *MouseLeaveTbxCommand+5D      .��5E   &   5F      �� 5H   
   -   5        $��Ctrl_Tbk_Ctxt��5H      $
��C : ��5I      $ Right=�5J      $��0��5K      $��2��5L      $	��100��5M      $��25��5N      �� 5O   
   -   5        $��
Ctrl_Tbk_C��5P      $��0��5Q      $��3��5R      $
 Left=�5S      $	��100��5T      $��25��5U      ��5O      �� *DataC+$ 0��5U      �� 5V   
   -   5        $��Ctrl_Tbk_Dtxt��5V      $
��D : ��5W      $ Right=�5X      $��1��5Y      $��2��5Z      $	��100��5[      $��25��5\      �� 5]   
   -	   5        $��
Ctrl_Tbk_D��5^      $��1��5_      $��3��5`      $
 Left=�5a      $	��100��5b      $��25��5c      ��5]      �� *DataD+$ 0��5c      5d      5e      