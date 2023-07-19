



using MyStack.Model;

//EasyStack<int> stack= new EasyStack<int>();

//stack.Push(3);
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//Console.WriteLine(stack);

//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack);


//LinkedStack<int> linkedStack= new LinkedStack<int>();
//linkedStack.Push(1);
//linkedStack.Push(2);
//linkedStack.Push(3);
//linkedStack.Push(4);
//linkedStack.Push(5);

//Console.WriteLine(linkedStack.Peek());
//Console.WriteLine(linkedStack.Pop());
//Console.WriteLine(linkedStack.Pop());
//Console.WriteLine(linkedStack.Pop());



ArrayStack<int> arrayStack= new ArrayStack<int>(2);

arrayStack.Push(1);
arrayStack.Push(2);

arrayStack.Peek();
arrayStack.Peek();
arrayStack.Peek();

arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop();

Console.ReadLine();