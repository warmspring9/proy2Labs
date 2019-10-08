Imports System
Imports System.Web.Mvc
Imports Testing

Module consoleVisual
    Sub Main(args As String())
        Dim sal As Single = 1
        While sal = 1
            sal = menu()
        End While



    End Sub
    Function menu() As Single
        Dim partner As New Testing.Controller()
        Console.WriteLine("Welcome")
        Console.WriteLine("Please choose the object to work with")
        Console.WriteLine("a)Clients")
        Console.WriteLine("b)Accounts")
        Console.WriteLine("c)Credits")
        Console.WriteLine("d)Directions")
        Dim op As String = Console.ReadLine()
        Dim options() As String = {"a", "b", "c", "d"}

        If options.Contains(op, StringComparer.CurrentCultureIgnoreCase) = False Then
            Console.WriteLine("Invalid option")
            Return 1
        End If

        Console.WriteLine("******************************")
        Console.WriteLine("What action do you wanna do?")
        Console.WriteLine("a)Create")
        Console.WriteLine("b)Retrive")
        Console.WriteLine("c)Retrive All")
        Console.WriteLine("d)Update")
        Console.WriteLine("e)Delete")
        Dim crudOp As String = Console.ReadLine()
        Dim crudOptions() As String = {"a", "b", "c", "d", "e"}

        If crudOptions.Contains(crudOp, StringComparer.CurrentCultureIgnoreCase) = False Then
            Console.WriteLine("Invalid option")
            Return 1
        End If

        crudOp = LCase(crudOp)
        op = LCase(op)
        If crudOp = "a" Then
            If op = "a" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Id")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Name")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Last Name")
                Dim inp3 As String = Console.ReadLine()
                Console.WriteLine("Birth date")
                Dim inp4 As String = Console.ReadLine()
                Console.WriteLine("Civil status")
                Dim inp5 As String = Console.ReadLine()
                Console.WriteLine("Gender")
                Dim inp6 As String = Console.ReadLine()
                Dim inputs() As String = {inp1, inp2, inp3, inp4, inp5, inp6}
                partner.Create(op, inputs)
            End If
            If op = "b" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Name")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Denomination")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Amount")
                Dim inp3 As String = Console.ReadLine()

                Dim inputs() As String = {inp1, inp2, inp3}
                partner.Create(op, inputs)
            End If
            If op = "c" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Amount")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Interest")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Name")
                Dim inp3 As String = Console.ReadLine()
                Console.WriteLine("Charge ")
                Dim inp4 As String = Console.ReadLine()
                Console.WriteLine("Start date")
                Dim inp5 As String = Console.ReadLine()
                Console.WriteLine("Status")
                Dim inp6 As String = Console.ReadLine()
                Console.WriteLine("Operation amount")
                Dim inp7 As String = Console.ReadLine()
                Dim inputs() As String = {inp1, inp2, inp3, inp4, inp5, inp6, inp7}
                partner.Create(op, inputs)
            End If
            If op = "d" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("State")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Province")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("District")
                Dim inp3 As String = Console.ReadLine()

                Dim inputs() As String = {inp1, inp2, inp3}
                partner.Create(op, inputs)
            End If
        End If
        If crudOp = "b" Then
            Console.WriteLine("Enter the id")
            Dim id = Console.ReadLine()
            Console.WriteLine(partner.Retrive(op, id))
        End If
        If crudOp = "c" Then
            Dim strings() As String = partner.RetrieveAll(op)
            Console.WriteLine("Lista")
            For index = 0 To strings.Length - 1
                Console.WriteLine(strings.GetValue(index))
            Next index
        End If
        If crudOp = "d" Then
            If op = "a" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Id")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Name")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Last Name")
                Dim inp3 As String = Console.ReadLine()
                Console.WriteLine("Birth date")
                Dim inp4 As String = Console.ReadLine()
                Console.WriteLine("Civil status")
                Dim inp5 As String = Console.ReadLine()
                Console.WriteLine("Gender")
                Dim inp6 As String = Console.ReadLine()
                Dim inputs() As String = {inp1, inp2, inp3, inp4, inp5, inp6}
                partner.update(op, inputs)
            End If
            If op = "b" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Name")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Denomination")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Amount")
                Dim inp3 As String = Console.ReadLine()

                Dim inputs() As String = {inp1, inp2, inp3}
                partner.update(op, inputs)
            End If
            If op = "c" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("Amount")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Interest")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("Name")
                Dim inp3 As String = Console.ReadLine()
                Console.WriteLine("Charge ")
                Dim inp4 As String = Console.ReadLine()
                Console.WriteLine("Start date")
                Dim inp5 As String = Console.ReadLine()
                Console.WriteLine("Status")
                Dim inp6 As String = Console.ReadLine()
                Console.WriteLine("Operation amount")
                Dim inp7 As String = Console.ReadLine()
                Dim inputs() As String = {inp1, inp2, inp3, inp4, inp5, inp6, inp7}
                partner.update(op, inputs)
            End If
            If op = "d" Then
                Console.WriteLine("Input the following lines...")
                Console.WriteLine("****************************")
                Console.WriteLine("State")
                Dim inp1 As String = Console.ReadLine()
                Console.WriteLine("Province")
                Dim inp2 As String = Console.ReadLine()
                Console.WriteLine("District")
                Dim inp3 As String = Console.ReadLine()

                Dim inputs() As String = {inp1, inp2, inp3}
                partner.update(op, inputs)
            End If

        End If
        If crudOp = "e" Then
            Console.WriteLine("Enter the id")
            Dim id = Console.ReadLine()
            partner.Delete(op, id)
        End If
        Console.WriteLine("0) Exit?")
        Dim xt = Console.ReadLine()
        Return If(xt.Equals("0"), 0, 1)
        Console.ReadKey(True)
    End Function
End Module
