   M S B A M L   `   `   `  ����H  DSpellenScherm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SpellenSchermSpellenScherm  5   	       SpellenScherm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SpellenScherm     5   	     � Title$  Memory Game v1.0��5   	   $
��1080��6"   $
��1920��60    � WindowState$ 	Maximized=�5	   	   ��5   =   Z� .��5      � ���#3C4986.+�5   
   � $
��Left=�6   $	��107��6*   $	��Top=�67   $
��1920��6O   ���#29387C$��0,0,-8,0q�6q   .+�5      �� -   5         ��Name$
 menu��5      $��Menu |||��6#   $
��Left=�66   $��0,66,0,0q�6Q   $	��Top=�6c   $	��212��6{   ���#5D689A J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Viner Hand ITC)�6�   $��41��6�   $��20(�6�   6�   5      �� 5   
   $��Memory Game V1.0��6   $
��Left=�6+   $��92��6F   $��
762,10,0,0q�6R   $	��Top=�6f   $	��528��6~   $��Viner Hand ITC)�6�   $��48(�6�   ���#5D689A��6�   Z� 6�   � 5   
   -   5         �Name$ users��5      $
��Left=�6   $	��618��69   $��
34,406,0,0q�6F   $	��Top=�6Z   $	��288��6r   ���#29387C.+�5      �� -   5         ��Name$ 
scoreName1��5      $��Scor0��6A   $
��Left=�6Q   $��	10,33,0,0q�6l   $	��Top=�6   $��55��6�   $	��268��6�   ���#5D689A$��36(�6�   $��Viner Hand ITC)�6�   $��2��6�   5      �� 5   
   -   5        $ start��5      $��Start��6    $
��Left=�60   $��1540,242,0,0q�6K   $	��Top=�6a   $	��297��6y   $��54��6�   $��Viner Hand ITC)�6�   $��36(�6�   ���#29387C���#5D689A6�   � 5   
   $
��Left=�6   $	��100��6*   $��
34,301,0,0q�67   $	��Top=�6K   $	��580��6c   ���#29387C � ColumnDefinitions 5      �� 5      $
��146* �6#   �� 5      $
��269* �6#   .+�5      �� -   5        $ name1��5      $��Player 1��6<   $
��Left=�6O   $��0,21,0,0q�6j   $	��Top=�6|   $��55��6�   $	��288��6�   ���#5D689A$��36(�6�   $��Viner Hand ITC)�6�   $��2��6�   �� 5      -   5        $ name2��5      $��Player 2��6<   $
��Left=�6O   $��
89,21,-1,0q�6j   $	��Top=�6~   $��55��6�   $	��288��6�   ���#5D689A$��36(�6�   $��Viner Hand ITC)�6�   $��1��6�   5      � 5   
   -   5        $ users2��5      $
��Left=�6   $	��618��6:   $��324,406,0,0q�6G   $	��Top=�6\   $	��288��6t   ���#29387C 5      �� 5      $
��146* �6#   �� 5       $
��269* �6#   .+�5"      �� -   5        $ 
scoreName2��5"      $��0��6A   $
��Left=�6M   $��6,34,0,0q�6h   $	��Top=�6z   $��55��6�   $	��268��6�   ���#5D689A$��36(�6�   $��Viner Hand ITC)�6�   $��2��6�   5#      � 5$   
   -	   5        $
 set1��5$      $
��Left=�6   $��54��68   $��
34,242,0,0q�6D   $	��Top=�6X   $	��580��6p   ���#29387C.+�5%      �� -
   5         ��Name$ 
nameEnter1��5%      $
��Left=�6*   $��34��6E   $��	45,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $��Player 1��6x   $	��Top=�6�   $	��200��6�   $ 0.311,0.552&�6�   ���#3C4986$��2��6�   $��22(�6�   �� 5&      -   5        $ 
nameEnter2��5&      $
��Left=�6*   $��34��6E   $��
335,10,0,0q�6Q   $
 Wrap=�6e   $��Player 2��6y   $	��Top=�6�   $	��200��6�   ���#3C4986$��1��6�   $��22(�6�   5'      �� 5(   
   ���#29387C$��1q�6'   $
��Left=�6;   $	��723��6V   $��779,301,0,0q�6c   $	��Top=�6x   $
��1058��6�   ���#29387C._�5)      � -   5        $ GameGrid��5)      $
��Left=�6%   $	��703��6@   $	��Top=�6M   $
��1038��6e   $ 0.191,0.183&�6r   ���#29387C$��9,9,0,0q�6�   5*      � 5+   
   -   5        $ menuBar��5+      $
��Left=�6    $��66��6;   $��
34,120,0,0q�6G   $	��Top=�6[   $
��1840��6s   ���	#FF29387C$y�	Collapsed=�6�   .+�5,      �� -   5        $ CloseMenuBar��5,      $��Close��6+   $
��Left=�6;   $��1740,10,0,0q�6V   $	��Top=�6k   $��80��6�   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   �� 5-      -   5        $ SaveGame��5-      $��	Save Game��6'   $
��Left=�6;   $��
20,10,0,10q�6V   $	��225��6j   $��Viner Hand ITC)�6v   ���#5D689A$��20(�6�   6�   �� 5.      -   5        $ LoadGame��5.      $��	Load Game��6'   $
��Left=�6;   $��
280,10,0,0q�6V   $	��Top=�6j   $	��225��6�   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   $ 0.5,0.5&�6�   6�   �� 5/      -   5        $ 	ResetGame��5/      $��
Reset Game��6(   $
��Left=�6=   $��
540,10,0,0q�6X   $	��Top=�6l   $	��225��6�   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   6�   �� 50      -   5        $ toMain��50      $��Main Screen��6%   $
��Left=�6;   $��
800,10,0,0q�6V   $	��Top=�6j   $	��225��6�   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   6�   �� 51      -   5        $ close��51      $��
Close Game��6$   $
��Left=�69   $��1060,10,0,0q�6T   $	��Top=�6i   $	��225��6�   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   6�   �� 52      -   5        $
 Help��52      $
��Help��6#   $
��Left=�62   $��1320,10,0,0q�6M   $	��Top=�6b   $	��225��6z   $��46��6�   $��Viner Hand ITC)�6�   ���#5D689A$��20(�6�   6�   53      � 54   
   -   5        $
 set2��54      $
��Left=�6   $��54��68   $��619,242,0,0q�6D   $	��Top=�6Y   $	��106��6q   ���#29387C.+�55      �� -   5        $ setNames��55      $	��Set��6'   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $��86��6{   ���#5D689A$ 0.585,0.971&�6�   $��34��6�   $��Viner Hand ITC)�6�   $��20(�6�   6�   56      59      5:      