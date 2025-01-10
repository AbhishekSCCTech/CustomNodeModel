using System.Windows.Controls;
using System.Windows.Data;
using Dynamo.Controls;
using Dynamo.Wpf;

namespace CustomNodeModel.CustomNodeModel
{
    public class CustomNodeModelView : INodeViewCustomization<GridNodeModel>
    {
        public void CustomizeView(GridNodeModel model, NodeView nodeView)
        {
            // Create the slider control
          
            // Bind the slider's Value property to the SliderValue property of the model
            // Set the Binding using SetBinding for the value property
            Binding binding = new Binding("SliderValue")
            {
                Source = model,
                Mode = BindingMode.TwoWay // Ensure two-way binding
            };

            var customComboBox = new CustomComboBox();

            // Add the slider to the input grid
            nodeView.inputGrid.Children.Add(customComboBox);
        }

        public void Dispose()
        {
            // Any necessary cleanup
        }
    }
}
