#if DEBUG

namespace SharpVoronoiLib;

internal sealed class RandomNaughtyPointGeneration : RandomPointGeneration
{
    private double[]? _goodXs;
    private double[]? _goodYs;
    private double[]? _badXs;
    private double[]? _badYs;
    private bool[]? _used;


    protected override void Prepare(IRandomNumberGenerator random, double minX, double minY, double maxX, double maxY, int count)
    {
        if (count < 40) throw new Exception();
        
        _goodXs = new double[count];
        _goodYs = new double[count];
        _badXs = new double[count];
        _badYs = new double[count];
        _used = new bool[count];

        for (int i = 0; i < count; i++)
        {
            _goodXs[i] = minX + 1.1 + random.NextDouble() * (maxX - minX - 2.2);
            _goodYs[i] = minY + 1.1 + random.NextDouble() * (maxY - minY - 2.2);
            _badXs[i] = _goodXs[i]; 
            _badYs[i] = _goodYs[i];
        }
        
        // X out of bounds
        _badXs[3] = minX;
        _badXs[7] = minX - 0.1;
        _badXs[11] = maxX;
        _badXs[15] = maxX + 0.1;
        
        // Y out of bounds
        _badYs[19] = minY;
        _badYs[23] = minY - 0.1;
        _badYs[27] = maxY;
        _badYs[31] = maxY + 0.1;
        
        // Duplicates
        _badXs[35] = _badXs[39] = 0.5;
        _badYs[35] = _badYs[39] = 0.5;
    }

    protected override double GetNextRandomValue(IRandomNumberGenerator random, double min, double max, int index, ValuePurpose valuePurpose)
    {
        double value = valuePurpose switch
        {
            ValuePurpose.X => _used![index] ? _goodXs![index] : _badXs![index],
            ValuePurpose.Y => _used![index] ? _goodYs![index] : _badYs![index],

            _ => throw new ArgumentOutOfRangeException(nameof(valuePurpose), valuePurpose, null)
        };
        
        _used![index] = true;
        
        return value;
    }

    protected override void Conclude()
    {
        // Don't need to do anything
    }
}


#endif