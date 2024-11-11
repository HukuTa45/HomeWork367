public interface IVehicle
{
    void D();
    void F();
    void S();
}

public class Car : IVehicle
{
    public void D()
    {
        Console.WriteLine("Car is driving");
    }

    public void F()
    {
        throw new InvalidOperationException("Cars cannot fly");
    }

    public void S()
    {
        throw new InvalidOperationException("Cars cannot swim");
    }
}

public class Boat : IVehicle
{
    public void D()
    {
        throw new InvalidOperationException("Boats cannot drive on roads");
    }

    public void F()
    {
        throw new InvalidOperationException("Boats cannot fly");
    }

    public void S()
    {
        Console.WriteLine("Boat is swimming");
    }
}