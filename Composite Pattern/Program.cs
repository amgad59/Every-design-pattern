


using Composite_Pattern.Neural_Network_using_Composite_pattern;

var neuron1 = new Neuron();
var neuron2 = new Neuron();
var layer1 = new NeuronLayer();
var layer2 = new NeuronLayer();

neuron1.ConnectTo(neuron2);
neuron1.ConnectTo(layer1);
layer1.ConnectTo(layer2);
/*
using Composite_Pattern.Composite_Pattern;

var drawing = new GraphicObject { Name = "My drawing" };
drawing.Children.Add(new Square { Color="Red"});
drawing.Children.Add(new Circle { Color="Yellow"});

var group = new GraphicObject();
group.Children.Add(new Circle { Color = "Blue"});
group.Children.Add(new Square { Color = "Blue"});
group.Children.Add(drawing);
Console.WriteLine(group.ToString());*/