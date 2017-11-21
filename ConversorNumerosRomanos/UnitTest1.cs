using Conversor;
using Shouldly;
using System;
using Xunit;

namespace ConversorNumerosRomanos
{
    public class UnitTest1
    {
        [Fact(DisplayName = "0001 deve ser I")]
        public void DeveRetornarI()
        {
            var result = Program.Calcular(1);
            result.ShouldBe("I");
        }

        [Fact(DisplayName = "0003 deve ser III")]
        public void DeveRetornarIII()
        {
            var result = Program.Calcular(3);
            result.ShouldBe("III");
        }

        [Fact(DisplayName = "0004 deve ser IV")]
        public void DeveRetornarIV()
        {
            var result = Program.Calcular(4);
            result.ShouldBe("IV");
        }

        [Fact(DisplayName = "0005 deve ser V")]
        public void DeveRetornarV()
        {
            var result = Program.Calcular(5);
            result.ShouldBe("V");
        }

        [Fact(DisplayName = "0009 deve ser V")]
        public void DeveRetornarIX()
        {
            var result = Program.Calcular(9);
            result.ShouldBe("IX");
        }

        [Fact(DisplayName = "0010 deve ser X")]
        public void DeveRetornarX()
        {
            var result = Program.Calcular(10);
            result.ShouldBe("X");
        }

        [Fact(DisplayName = "0030 deve ser XXX")]
        public void DeveRetornarXXX()
        {
            var result = Program.Calcular(30);
            result.ShouldBe("XXX");
        }

        [Fact(DisplayName = "0037 deve ser XXXVII")]
        public void DeveRetornarXXXVII()
        {
            var result = Program.Calcular(37);
            result.ShouldBe("XXXVII");
        }

        [Fact(DisplayName = "0039 deve ser XXXIX")]
        public void DeveRetornarXXXIX()
        {
            var result = Program.Calcular(39);
            result.ShouldBe("XXXIX");
        }

        [Fact(DisplayName = "0179 deve ser CLXXIX")]
        public void DeveRetornarCLXXIX()
        {
            var result = Program.Calcular(179);
            result.ShouldBe("CLXXIX");
        }

        [Fact(DisplayName = "0221 deve ser CCXXI")]
        public void DeveRetornarCCXXI()
        {
            var result = Program.Calcular(221);
            result.ShouldBe("CCXXI");
        }

        [Fact(DisplayName = "0273 deve ser CCLXXIII")]
        public void DeveRetornarCCLXXIII()
        {
            var result = Program.Calcular(273);
            result.ShouldBe("CCLXXIII");
        }

        [Fact(DisplayName = "0347 deve ser CCCXLVII")]
        public void DeveRetornarCCCXLVII()
        {
            var result = Program.Calcular(347);
            result.ShouldBe("CCCXLVII");
        }

        [Fact(DisplayName = "0500 deve ser D")]
        public void DeveRetornarD()
        {
            var result = Program.Calcular(500);
            result.ShouldBe("D");
        }

        [Fact(DisplayName = "0628 deve ser DCXXVIII")]
        public void DeveRetornarDCXXVIII()
        {
            var result = Program.Calcular(628);
            result.ShouldBe("DCXXVIII");
        }

        [Fact(DisplayName = "0777 deve ser DCCLXXVII")]
        public void DeveRetornarDCCLXXVII()
        {
            var result = Program.Calcular(777);
            result.ShouldBe("DCCLXXVII");
        }

        [Fact(DisplayName = "0961 deve ser CMLXI")]
        public void DeveRetornarCMLXI()
        {
            var result = Program.Calcular(961);
            result.ShouldBe("CMLXI");
        }

        [Fact(DisplayName = "0870 deve ser DCCCLXX")]
        public void DeveRetornarDCCCLXX()
        {
            var result = Program.Calcular(870);
            result.ShouldBe("DCCCLXX");
        }

        [Fact(DisplayName = "0978 deve ser CMLXXVIII")]
        public void DeveRetornarCMLXXVIII()
        {
            var result = Program.Calcular(978);
            result.ShouldBe("CMLXXVIII");
        }

        [Fact(DisplayName = "1985 deve ser MCMLXXXV")]
        public void DeveRetornarMCMLXXXV()
        {
            var result = Program.Calcular(1985);
            result.ShouldBe("MCMLXXXV");
        }

        [Fact(DisplayName = "2363 deve ser MMCCCLXIII")]
        public void DeveRetornarMMCCCLXIII()
        {
            var result = Program.Calcular(2363);
            result.ShouldBe("MMCCCLXIII");
        }

        [Fact(DisplayName = "2599 deve ser MMDXCIX")]
        public void DeveRetornarMMDXCIX()
        {
            var result = Program.Calcular(2599);
            result.ShouldBe("MMDXCIX");
        }

        [Fact(DisplayName = "2878 deve ser MMDCCCLXXVIII")]
        public void DeveRetornarMMDCCCLXXVIII()
        {
            var result = Program.Calcular(2878);
            result.ShouldBe("MMDCCCLXXVIII");
        }

        [Fact(DisplayName = "3275 deve ser MMMCCLXXV")]
        public void DeveRetornarMMMCCLXXV()
        {
            var result = Program.Calcular(3275);
            result.ShouldBe("MMMCCLXXV");
        }

        [Fact(DisplayName = "3527 deve ser MMMDXXVII")]
        public void DeveRetornarMMMDXXVII()
        {
            var result = Program.Calcular(3527);
            result.ShouldBe("MMMDXXVII");
        }

        [Fact(DisplayName = "3999 deve ser MMMCMXCIX")]
        public void DeveRetornarMMMCMXCIX()
        {
            var result = Program.Calcular(3999);
            result.ShouldBe("MMMCMXCIX");
        }
    }
}
