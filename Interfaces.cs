
namespace DZ_CS_7
{
    internal interface IICalc: IICalc1 , IICalc2
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
        public void Show();
        
    }
    internal interface IICalc1
    {
        void ShowEven();
        void ShowOdd();
    }
    internal interface IICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
