using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerList : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        List<string> newList = new List<string>();
        newList = GenerateLists();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public List<string> GenerateLists()
    {

        string[] objects =
        { "apple", "appleHalf", "avocado", "avocadoHalf", "bacon",  "baconRaw",
        "bag", "bagFlat", "banana", "barrel", "beet", "bottleKetchup", "bottleMusterd", "bottleOil", "bowl",
        "bowlBroth", "bowlCereal", "bowlSoup", "bread", "broccoli", "burger", "burgerCheese", "burgerCheeseDouble",
        "burgerDouble", "cabbage", "cake", "cakeBirthday", "cakeSlicer", "can", "candyBar", "candyBarWrapper", "canOpen",
        "canSmall", "carrot", "carton", "cartonSmall", "cauliflower", "celeryStick", "cheese", "cheeseCut", "cheeseSlicer",
        "cherries", "chinese", "chocolate", "chocolateWrapper", "chopstick", "chopstickFancy", "cocktail", "coconut", "coconutHalf",
        "cookie", "cookieChocolate", "cookingFork", "cookingKnife", "cookingKnifeChopping", "cookingSpatula", "cookingSpoon", "corn",
        "cornDog", "croissant", "cup", "cupcake", "cupSaucer", "cupTea", "cupThea", "cuttingBoard", "cuttingBoardJapanese",
        "cuttingBoardRound", "dimSum", "donut", "donutChocolate", "donutSprinkles", "egg", "eggCooked", "eggCup", "eggHalf",
        "eggplant", "fish", "fishBones", "frappe", "fries", "friesEmpty", "frikandelSpeciaal", "fryingPan", "fryingPanLid",
        "gingerBread", "gingerBreadCutter", "glass", "glassWine", "grapes", "honey", "hotDog", "hotDogRaw", "iceCream", "iceCreamCone",
        "iceCreamCup", "iceCreamScoop", "iceCreamScoopMint", "knifeBlock", "leek", "lemon", "lemonHalf", "loaf", "loafBaguette",
        "loafRound", "lollypop", "makiRoe", "makiSalmon", "meatCooked", "meatPatty", "meatRaw", "meatRibs", "meatSausage", "meatTenderizer",
        "mincemeatPie", "mortar", "mortarPestle", "muffin", "mug", "mushroom", "mushroomHalf", "mussel", "musselOpen", "onion",
        "onionHalf", "orange", "pan", "pancakes", "panStew", "paprika", "paprikaSlice", "peanutButter", "pear", "pearHalf", "pepper",
        "pepperMill", "pie", "pineapple", "pizza", "pizzaBox", "pizzaCutter", "plate", "plateDeep", "plateDinner", "plateRectangle",
        "plateSauerkraut", "popsicle", "popsicleChocolate", "popsicleStick", "pot", "potLid", "potStew", "potStewLid", "pudding",
        "pumpkin", "pumpkinBasic", "radish", "riceBall", "rollingPin", "salad", "sandwich", "sausage", "sausageHalf", "shakerPepper",
        "shakerSalt", "skewer", "skewerVegetables", "soda", "sodaBottle", "sodaCan", "sodaCanCrushed", "sodaGlass", "soy", "steamer",
        "strawberry", "styrofoam", "styrofoamDinner", "sub", "sundae", "sushiEgg", "sushiSalmon", "taco", "tajine", "tajineLid",
        "tomato", "tomatoSlice", "turkey", "utensilFork", "utensilKnife", "utensilSpoon", "waffle", "watermelon", "whippedCream",
        "whisk", "wholeHam", "wholerHam", "wineRed", "wineWhite"
        };

        System.Random random = new System.Random();
        List<String> checklist = new List<String>();

        for (int i = 0; i < 8; i++)
        { 
            int a = random.Next(objects.Length);
            checklist.Add(objects[a]);

        }
        return checklist;

    }
}