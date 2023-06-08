using System;

namespace CSharpFunctionalImperativeOOPDynamicProgramming
{
    delegate void ButtonClick(Button button);

    class Button
    {
        public ButtonClick Click;

        public void SimulateClick()
        {
            Click(this);
        }
    }

    class MultiCastDelegatesWithWPFForm
    {

        static void Main (string[] args)
        {
            var button = new Button();
            button.Click += ButtonClickedBehaviour;
            button.Click += OtherButtonClickedBehaviour;

            button.SimulateClick();
            Console.ReadKey();
        }

        static void OtherButtonClickedBehaviour(Button button)
        {
            Console.WriteLine("Other Button Clicked!");
        }

        static void ButtonClickedBehaviour(Button button)
        {
            Console.WriteLine("Button Clicked!");
        }
    }
}
