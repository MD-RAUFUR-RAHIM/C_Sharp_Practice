// See https://aka.ms/new-console-template for more information
using ExpressionWithAnimalExample;
using System.Linq.Expressions;

AnimalActions animal = new AnimalActions();
var dogBarkMethod = Expression.Call(
    typeof(AnimalActions).GetMethod("MakeDogBark")
    );
var compiled = Expression.Lambda<Action>(dogBarkMethod).Compile();
compiled();

//Same task using the help of Lambda

Expression<Action> catMeow = Expression.Lambda<Action>(
            Expression.Call(
                typeof(AnimalActions).GetMethod("MakeCatMeow")
            )
        );
catMeow.Compile()();