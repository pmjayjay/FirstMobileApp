using FirstMobileApp.ViewModel;

namespace CalUTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            CalViewModel viewModel = new CalViewModel();
            viewModel.Num1 = 10;
            viewModel.Num2 = 20;
            var result = viewModel.Add();

            Assert.IsTrue(result == viewModel.Num1+viewModel.Num2);
        }

        [Test]
        public void SubTest()
        {
            CalViewModel viewModel = new CalViewModel();
            viewModel.Num1 = 20;
            viewModel.Num2 = 10;
            var result = viewModel.Sub();

            Assert.IsTrue(result == viewModel.Num1 - viewModel.Num2);
        }

        [Test]
        public void MulTest()
        {
            CalViewModel viewModel = new CalViewModel();
            viewModel.Num1 = 10;
            viewModel.Num2 = 20;
            var result = viewModel.Mul();

            Assert.IsTrue(result == viewModel.Num1 * viewModel.Num2);
        }

        [Test]
        public void DivTest()
        {
            CalViewModel viewModel = new CalViewModel();
            viewModel.Num1 = 20;
            viewModel.Num2 = 10;
            var result = viewModel.Div();

            Assert.IsTrue(result == viewModel.Num1 / viewModel.Num2);
        }
    }
}