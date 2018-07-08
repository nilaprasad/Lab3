# Lab3
Code for Lab 3

Design a C# Windows Forms Application that uses two classes and an interface named Device, TestDevice and ITest respectively.
The Device class should contain data fields to store a device description, serial number, and date of the most recent test. This class should also contain all necessary properties/methods to set
and get values of these data fields.

The ITest interface should contain two properties and a method. The first property will be used to get and set a description of a measurement to be done on a device when doing a test. The
second property will be used to get and set a number of tests per year. In addition to these two properties the ITest interface should also contain a method that will be used to compute the
date when a specific device is due for the next test.

The TestDevice class should inherit Device and ITest. Please note that this class must implement/define the two properties and the method from the ITest interface.
Design a Windows Form class that will create and use an array of TestDevice objects. The form will also contain controls that can be used to obtain the device and test data from the user as
well as to display when a selected device is due for the next test. The form class will also have a static constructor that will use a message box to display the current system date and time.
Please note that the console I/O could also be used within a Windows form application as well.
