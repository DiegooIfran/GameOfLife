

namespace Ucu.Poo.GameOfLife;

public class Cell // Su razon de cambio es el tipo  de las celulas (en este caso Bool)
{
    public bool Alive { get; set; }

    public Cell() // Clase constructora de celulas, con alive en false por defecto
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