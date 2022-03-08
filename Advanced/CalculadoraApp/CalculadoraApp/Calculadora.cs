namespace CalculadoraApp;

public class Calculadora
{
    private int x;
    private int y;
    private readonly bool _isValid;

    //public Calculadora(int x, int y)
    //{
    //    if (x <= 0 || y <= 0)
    //        _isValid = false;

    //    string str = null;
    //}

    public int? Sum1()
        => _isValid ? x + y : null;
    

    public int? Sum(int num1, int num2)
    {
        var _isValid = InputsAreValid(num1, num2);

        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
        => num1 - num2;


    private bool InputIsValid(int input) => input >= 0;
   
    private bool InputsAreValid(params int[] inputs)
    {
       // return inputs.All(input => input > 0);

        foreach (var input in inputs)
        {
            if (input <= 0)
                return false;
        }

        return true;
    }

    public int Multiply(params int[] inputs)
    {
        var res = 1;

        foreach (var input in inputs)
            res *= input;   

        return res;
    }

    public int Divide(int x, int y)
    {
        if (y == 0)
            throw new Exception("O divisor não pode ser 0");
        
        return x / y;
    }

    public (int Min, int Max) MinMax(params int[]nums)
        => (nums.Min(), nums.Max());

    public (decimal Lat, decimal Long) GetCoordinates()
    {
        return (1.23423m, 0.87632m);
    }

}