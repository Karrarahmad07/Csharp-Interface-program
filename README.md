Description
--------------------------------------------------------------

It's a program that uses interface for abstraction of the methods for multiple objects.

It consist of PowerOn method which is used to perform PowerOn operation on different objects, include Light Bulb or Computer in this Program while keeping the implementation hidden from the user.

Points About Program:
--------------------------------------------------------------

1. First thing, program has inferface which consist of PowerOn Method with No body as usually the interface method don't have.

2. Interface acts like polymorphism, which takes override function from the derived class.

3. Derived class can be multiple or list of devices which has their own object and assigned to the interface

Working
----------------------------------------------------------------

1. Consist of interface named as Powerable with empty method

2. The derived class consist the working of the method of the Light Bulb

3. The 2nd derived class consist the working of the method of the Computer

4. The main class creates the object of these 2 devices, assigned to interface

5. Object associated with the derived class method is executed when called

