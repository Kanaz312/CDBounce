# CDBounce
This is a fake bouncing CD logo program, as part of a coding challenge from  Amir Rajan.

This program had me writing 58 lines of code (there are 87 lines total, but a lot of boilerplate created by Unity).

I had to be knowledgeable of the 
  - basic Unity game camera
  - conversion of local to world coordinates/scales
  - vectors (though all calculations are handled in unity mehtods)
  - Unity's spriterenderer component and Color system

I had to use classes (game objects), as that is how all Unity games are. Unity requires this use of classes for trivial games like this so that they can easily be scaled up without much overhead. Also, when creating scripts for the classes, much of the setup is handled by Unity, so it's not as involved as implementing a class with Ruby.

I had to start and stop execution roughly 30 times. This process is simply pressing a play button, then pressing it again to stop. Running from within Unity doesn't take that long, the only "long" wait is compiling the scripts when tabbing in and out of Unity. This usually takes only a handful of seconds, but it adds up.

For editing the world/scene, you are required to use the Unity IDE. When first using it, there is a lot of information to take in. It probably took me 3 days to get comfortable with the IDE, and there still many tools inside it that I am not aware of. For writing scripts, you are able to use whatever IDE you want.

The source code is easily shareable, but large so transfer takes a while. You have to send the scene data, any scripts written, packages, project settings, and a log folder (contains package update txt). The scene data contain all the information of what you game world has, the scripts are self explanitory, the packages is any packages you used that are not included with base Unity, and the project settings includes things like the window (player) information and input methods.

Setting up the 1280x720 canvas was straightforward. It simply requires throwing `Screen.SetResolution(1280, 720, true);` in a script of your choice (I chose one attached to the camera).

Switching between versions during development was very easy; there is a tab that handles the conversion. Exporting for PC and Web was also very easy. Exporting to mobile was more difficult, and to my understanding you need to have an android/ios device connected in order to export. It should be noted that adjusting the scripts to be touch compatible instead of keyboard compatible was very simple.

The output binary size was 59MB.

I would say the main pain of Unity, especially while learning, is the sheer amount of tools available. It can be overwhelming to figure out what tools will get the job done, and what tweaking might be needed to have it fit correctly. I find that I often have multiple tabs of the docs and various threads of the forums open while programming. I will say that the docs are very well made. It is very clear about what the classes include and has hyperlinks whenever a class or method is mentioned. That all helps make the lookup process much faster than it would be otherwise.
