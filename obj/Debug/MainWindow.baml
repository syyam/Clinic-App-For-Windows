   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ContainerWpfApp1.Container  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,customclr-namespace:WpfApp1.Container  5   	   -   5          �Name$
  frog��5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowState$ 	Maximized=�5
   	    � WindowStyle$
 None=�5   	    � Title$
 Main��5   	   
�������.��5      � 
�������.+�5   
   ]� ��.  ���	#FF292728$
��Left=�6A   $	��234��6\   ]� 5   
   ��.  $��	234,0,0,0q�6*    J� RenderTransformOrigin$ 0.501,-0.507&�6=   ���#558b2f$��25��6w   $	��Top=�6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��21��6J   $	��Top=�6V   $	��342��6n   .+�5      �� $	��FAQ��6   ���	#FFE2E2E2$��15(�6g   $	��Top=�6v   $��	0,-6,0,-5q�6�   ��6#   Z� ��69   Z� 6�   �� 5      -   5        $��LOGOUT��5      ���	#FFE2E2E2$��15(�6j   $��Center=�6y   ��6&   Z� ��6<   Z� 6�   �� 5      $��
MY ACCOUNT��6   ���	#FFE2E2E2$��15(�6n   $��Center=�6}   ��6*   Z� ��6@   Z� 6}   �� 5      -   5         0  ,MaterialDesignFloatingActionMiniAccentButton#��[  5   B   $��
0,-10,0,-9q�6�   $��40��6�   $��Bottom=�6�   ��6   Z� ��6+   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6*   ���#fff$��25��6I   $��25��6T   5      5      ]� 5   
   $	��200��6   ��.  $��	301,0,0,0q�67   $	��Top=�6J   $
��Left=�6b   $	��205��6}   ���#558b2f6�   �� 5    
   $��Images/logo2.png��6   $
��Left=�6*   $��92��6E   $��
356,42,0,0q�6Q   $	��Top=�6e   $��86��6}   �� 5!   
   $��Hassaan Poly clinic��6   $
��Left=�6.   $��301,139,0,0q�6I   $	��Top=�6^   
�������$��20(�6�   $��Century Gothic)�5"      $��38��6,   $	��205��68   $��Center=�6D   �� 5#   
   -   5        $��homeBtn��5#      $
��Home��6    $��	0,108,0,0q�6/   $	��Top=�6B   $��69��6Z   $
��Left=�6f   $	��234��6�   
�������$��0 0 0 0q�6�   ��5$      �� 5%       �� Color$ 	#FF1D1D1D��6"   	 �� Opacity$	 0Q�64   5'      �� 5)   
   -   5        $��progressBtn��5)      $��	View Data��6$   $��	0,176,0,0q�68   $	��Top=�6K   $��69��6c   $
��Left=�6o   $	��234��6�   
�������$��0 0 0 0q�6�   ��5*      �� 5+      $ 	#FF1D1D1D��6"   $	 0Q�64   5-      �� 52   
   -   5        
 ��Name$
 SidePanelHome��52      $
��Left=�6,   $��69��6G   $��	0,108,0,0q�6T   $	��Top=�6g   $��12��6   ���	#FF558B2F6�   �� 53   
   -   5        $
 SidePanelProgress��53      $
��Left=�60   $��69��6K   $��	0,176,0,0q�6X   $	��Top=�6k   $��12��6�   ���	#FF558B2F6�   � 55   
   -   5         �Name$
 root��55      $
��1200��6   $	��700��6+   $��300,94,50,50q�68   .+�56      &    WpfApp1.Container.HomeContainier  $��10q�6$   59      5=      5>      