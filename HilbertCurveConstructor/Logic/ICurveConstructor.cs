namespace HilbertCurveConstructor.Logic
{
    public interface ICurveConstructor
    {
         void BuildCurve();
         void Clear();
         void ExcelExport(string path);
    }
}