namespace functionsAndLoops
{
    public enum Shape
    {
        Square,
        Circle,
        Triangle,
        Rectangle
    }
    internal class Geometry
    {



        /// <summary>
        /// Bu fonksiyon kare ve dairenin alanını hesaplar 
        /// </summary>
        /// <param name="unit1">double birim uzunluk</param>
        /// <param name="shape">Kare ya da daire</param>
        /// <returns></returns>
        public double GetArea(double unit1, Shape shape)
        {

            var result = 0.0;
            //switch (shape.ToLower())
            //{
            //    case "daire":

            //        break;
            //    case "kare":

            //        break;
            //    default:

            //        break;
            //}


            switch (shape)
            {
                case Shape.Square:
                    result = Math.Pow(unit1, 2);
                    break;
                case Shape.Circle:

                    result = Math.Pow(unit1, 2) * Math.PI;
                    break;
                default:
                    break;
            }
            return result;

        }
        public double GetArea(double unit1, double unit2, Shape shape)
        {
            var result = 0.0;
            switch (shape)
            {
                case Shape.Triangle:
                    result = (unit1 * unit2) / 2;
                    break;
                case Shape.Rectangle:
                    result = unit2 * unit1;
                    break;
                default:
                    break;
            }
            return result;
        }
        // public double GetArea(Shape shape, double unit1) { return 0.0; }
        // public int GetArea(double unit1, Shape shape) { return 0; }

        public double GetAreaOptional(double unit1, double unit2 = 1, Shape shape = Shape.Square)
        {
            var area = 0.0;
            switch (shape)
            {
                case Shape.Square:
                    area = Math.Pow(unit1, 2);
                    break;
                case Shape.Circle:
                    area = Math.Pow(unit1, 2) * Math.PI;

                    break;
                case Shape.Triangle:
                    area = (unit1 * unit2) / 2;

                    break;
                case Shape.Rectangle:
                    area = unit2 * unit1;
                    break;
                default:
                    break;
            }

            return area;
        }
    }
}
