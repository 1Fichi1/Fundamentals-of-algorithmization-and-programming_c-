   M S B A M L   `   `   `  ����   PracticalWork3    PracticalWork3.MainWindow   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  	APleer ))��$	��590��$	��900��
�������.��� ����  �� ImageSource$c ]C:\Users\Дамир\Desktop\PW3 C#\1653517906_62-celes-club-p-fon-dlya-pleera-krasivie-66.jpg�� � RowDefinitions �� $
��169* ��� $
��421* � � ColumnDefinitions �� $
��119* ��� $	��61* �.+��� -    ��Name$ CurrentSongName��
�������$��Tahoma)�$��92,120,288,21q�$	��215�� � Triggers :�  :� RoutedEvent$ TextBlock.Loaded��.[��� .���� .��W�  �� 
TargetName$ CurrentSongName�� �� TargetProperty$ (TextBlock.Width)�		 W� To$		 0.0X�
 g� Duration$
 0:0:5D� g� AutoReverse .  g� RepeatBehavior$ Forever���� -    ��Name$ SongPositionSlider��
����  � �� IsMoveToPointEnabled .  �� TickFrequency$ 1Q�$��2��$��36,32,74,103q��� -   $ NowTime��$��0��$��0��$��10,130,550,4q�$��30���� -   $ RemainingTime��$��1��$��0��$��265,130,10,5q�$��30��$��30���� -   $ VolumeSlider��
����  �$��1��$��66,82,74,51q��� -    ��Name$ 
VolumeIcon��$��0,77,275,57q�$��1��$��
volume.png���� -    ��Name$ Play_Button��   MaterialDesignIconButton#��[  $��384,61,171,63q�$��40��$��40��
�������.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Play=�$��40��$��40��$��Center=��� -   $ Stop_Button��#��[  $��329,66,236,68q�$��30��$��30��
�������.��  $
 Stop=�$��25��$��25��$��Center=��� -	   $ PreviousSong_Button��#��[  $��269,66,296,68q�$��30��$��30��
�������.��  $ SkipPrevious=�$��25��$��25��$��Center=��� -
   $ Pause_Button��#��[  $��449,66,116,68q�$��30��$��30��
�������.��  $ Pause=�$��25��$��25��$��Center=��� -   $ NextSong_Button��#��[  $��509,66,56,68q�$��30��$��30��
�������.��  $ SkipNext=�$��25��$��25��$��Center=��� -   $ Loop_Button��#��[  $��404,104,171,40q�$��20��$��20��
�������.��  $
 Loop=�$��15��$��15��$��Center=��� -   $ Random_Button��#��[  $��385,104,190,40q�$��20��$��20��
�������.��  $ Shuffle=�$��15��$��15��$��Center=� J� RenderTransformOrigin$ 0.593,0.562&��� -   $ FolderOpen_Button��#��[  $��1��$��206,122,59,2q�$��40��$��40��
�������.��  $
 Plus=�$��40��$��40��$��Center=�$��Center=��� -    ��Name$ songList��$��	2,1,288,0q�$��1��
�������r� -    r�Name$ mediaElement��$��87,44,217,208q� r� LoadedBehavior$ Manual=�$��2��$��1��