using System;
using System.Collections.Generic;
using System.Text;

public class Tyre
{
    private double pressure;
    private int years;

    public double Pressure
    {
        get { return pressure; }
        set { pressure = value; }
    }

    public int Years
    {
        get { return years; }
        set { years = value; }
    }

    public Tyre(double pressure, int years)
    {
        this.pressure = pressure;
        this.years = years;
    }
}