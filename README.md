# CSharp.10.Generics

un generic sirve para reutilizar una clase o metodo
el tipo de parametro tambien es ingresado a la clase o metodo con los simbolos <>

Tambien podemos especificar el tipo
```csharp
where T : struct //tipo valor 
where T : class // tipo referencia
Where T : new() //constructor sin parametros
Where T : IExample //Interfaz concreta
Where T : Example //una clase concreta
```
para clases
```csharp
public class ExampleGeneric<T>
public T Value { get; set; }

ExampleGeneric<string> eg = new ExampleGeneric<string>();
ExampleGeneric<int> egInt = new ExampleGeneric<int>
{
    Value = 1
};
```

para metodos:
```csharp
class person
    public string Concatenar<G>(G left, G right)
    {
        //string result = string.Empty;
        StringBuilder result = new StringBuilder();
        result.Append(left);
        result.Append(right);

        return result.ToString();
    }

Console.WriteLine( $"int: {person.Concatenar<int>(2,2)}" );
```
