// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateAccessModifiers // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1998, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }





    }
}


/*
 Access Modifiers

Public
Private
Protected
Internal
Protected Internal

So what is an access modifier and why?
Access modifier is a way to control access to a class and or it's members.
The reason is to create some kind of safety or guarding our applications to improve the robustness.


Notes:

I explain how we can use the read only modifier to make sure that the field is assigned only once.

And this way we developers will not accidentally create bugs in our code.

When we declare an instance of the customer we cannot access the name field so we cannot go John dot

name that will not compile.

Now you may wonder why do we need something like that.

Well that's the beginning of object oriented programming and object oriented programming which is actually

one of my absolute favorite topics.

We have three major concepts encapsulation which is also referred to as information hiding inheritance

and polymorphism.

In this lecture we're going to learn about encapsulation and throughout this course we'll see more examples

of that encapsulation.

We're going to leave inheritance and polymorphism to the later section in this course.

Let's start with encapsulation.

I want to use an analogy think of a restaurant in a restaurant we have several roles.

We have a cashier we have a manager.

We have a chef.

We have one or more kitchen hands.

We have one or more waiters or waitresses and all these roles collaborate together to provide an amazing

experience for you.

Well hopefully because sometimes we go to a restaurant and we come back very disappointed.

But anyway think of the interaction between a waitress and a chef.

A waitress takes the order and passes it to the kitchen and the chef looks at the order and does his

job and when he's ready it notifies the waitress so that chef is responsible for a few things which

is outside the responsibility of the waitress the waitress is not going to go to the kitchen tell the

chef how to chop the vegetables and how to cook the meat.

And I don't know about different spices.

Each of these roles are responsible for their own things.

They have some knowledge and some capabilities that perform some functions suffer should be the same

in sulfur.

We don't have a chef or a waitress but we have classes and these classes collaborate to perform the

functionality required from the application.

Now we want to design our classes such that each class is responsible for one thing it does only one

job and does it perfectly.

We want our classes to hide some of the information about how they do the things they are responsible for.

We don't want other classes to know about the details of other classes. And this is what we call encapsulation.

So we want to encapsulate some data in terms of fields as well as some behavior or functionality in terms of methods and classes.

And we want to hide the details from the outside.

So when it comes to fields we want to declare them as private and provide methods that would give access

to these fields. We call these methods getters and setters and these methods are going to be public.

So we think of fields as the implementation detail which should be invisible from the outside. It's how a class store something in memory.

We don't want any other classes to know anything about that.

So to show you an example here we have a person class that has a name field that is declared as private.

So with this code if we create an instance of the person class we can access the name field of that object.

Instead we need to call one of the methods here said name or get any look at the set named method here.

The interesting thing about this method is that it does a check before assigning the name field of the person.

So if the value that is passed to this method and as the argument is null or empty it's not going to set the name field.

And this is one of the advantages of providing setters and getters.

We can know that you have the same thing with a field if field is purely storage in the memory.

It doesn't have logic with a setter or a getter.

We can have some logic when accessing that field.



Encapsulation:

Define fields as private
Provide getter/setter methods as public


What I want you to take away from this lecture is you're going to declare our fields as private and

the naming convention is under line and Kemel case in the real world applications we are not going to

define two methods like the ones you see here.

 */