   M S B A M L   `   `   `  ����M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel  5   
   D @TcpServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TcpServer	TcpServer 5   	      TcpServer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Bcm3clr-namespace:System.ComponentModel;assembly=System     5   
   )localclr-namespace:TcpServer     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      ,   &System.ComponentModel.BackgroundWorker   backgroundWorker!   WorkerSupportsCancellation  placeHolder �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType ��Name	 K� ZIndex
 �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding �� Source%  System.Windows.Markup.Reference �� Value��%�  &	        &	 ,     7��  5   
   -   5         . 5   |   �� 5   
   " ��6$   8   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ 
textSource��5   "   
������ $	 2��5   "   ��5   &   �� $

 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5   "   �� 5      #��z 6&   #��z��6C   $	 1��6m   .��6~   ��5   "   �� 5   &   " ��6,   .�5   *   ��  � ��
 ���� 6G    5   *   �� 5   .    6:   �� $

 Text�   *
textSource+  6y   .a�5   2   ��  � ��
 �����6O   5   /   5!   '   .��5"   1   5#      5$      5%      5'      5(      5)      .��5*      � .+�5+   
   �� $
��Left=�6   $��30��6-   $	��Top=�69   $	��101��6Q   $��
348,92,0,0q�6]   �� 5,   
   $��ip адресс��6   $
��Left=�6$   $	��Top=�6?   $��
124,50,0,0q�6W   $��37��6k   $	��101��6w   �� 5-   
   $��порт��6   $
��Left=�6   $	��Top=�6:   $��
348,50,0,0q�6R   $��37��6f   $	��101��6r    J� RenderTransformOrigin$ 0.089,0.507&�6~   �� 51   
   -   5        $ hostname��51   #   $ 
google.com��6   $
��Left=�65   $��30��6P   $��
124,92,0,0q�6\    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��177��6�   �� 52   
   -   5         ��Name$ 	ReplyList��52      $
��Left=�6&   $	��165��6A   $��124,140,0,0q�6N   $	��Top=�6c   $	��464��6{   54      �� 55   
   -   5         ��Name$ start��55      $��Start��6    $
��Left=�60   $��
474,92,0,0q�6K   $	��Top=�6_   $��50��6w   $��24��6�   6�   �� 56   
   -   5        $
 stop��56      $
��Stop��6   $
��Left=�6.   $��
538,92,0,0q�6I   $	��Top=�6]   $��50��6u   $��24��6�   $ -0.08,0.681&�6�   58      59      