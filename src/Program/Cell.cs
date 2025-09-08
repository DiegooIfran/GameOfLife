namespace Program;

public class Cell
{
    public bool Alive { get; set; }

    public Cell()
    {
        Alive = false;
    }
    
    public void Born()
    {
        Alive = true;
    }

    public void Die()
    {
        Alive = false;
    }
}