### Bridge Design Pattern Demo

#### Overview
Bridge pattern is a structural design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently".
* Real world applications of bridge pattern include Notification Systems, Remote Control, Printers, GUI Libraries etc.. 
* GUI libraries often use the bridge pattern to separate the high-level GUI components (such as buttons and menus) from the platform-specific implementation details. This allows developers to create cross-platform GUIs that work on different operating systems. This can also be implemented as LongView , ShortView (platform specific) of different pages. 
</br> Due to complexities of implementation of visualization of different pages as long view & short view, this project implements DetailView & BriefView of Visualization of Shapes (i.e. description of shapes) 

#### UML Diagram 
These are the 4 important elements of bridge design pattern. 

![UMLDiagram](https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Bridge_UML_class_diagram.svg/500px-Bridge_UML_class_diagram.svg.png)


Elements included in this project as per the above UML Diagram : 
* Abstraction : Shape 
</br> Contains the reference to the implementer (IDiagramView) and defines the abstract interface having a client function "Display()"

* Refined Abstraction : Circle , Square
</br> extends the abstraction(Shape) with finer details one level below

* Implementer : IDiagramView
</br> IDiragramView defines a contract with functions : DisplayCircle() , DisplaySquare()

* Concrete Implementations : DetailedView , BriefView

#### Class Diagram 
![ClassDiagram](https://github.com/nikhi9603/BridgePatternDemo/blob/main/Images/ClassDiagram.jpeg)

#### Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.