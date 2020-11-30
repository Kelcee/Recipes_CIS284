using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes_FinalProject.Database.Entity;

namespace Recipes_FinalProject.Database
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipesContext(serviceProvider.GetRequiredService<DbContextOptions<RecipesContext>>()))
            {
                if (context.Recipes.Any()) { return; }

                context.Recipes.AddRange(new[] {
                        new Recipe
                        {
                            Title = "Peanut Butter Jelly Sandwich",
                            Description = "A yummy sandwich.",
                            PrepTime = "5 minutes",
                            CookTime = "5 minutes",
                            Yields = "Sandwich for 1",
                            ImagePath = "~/images/PBJ.jpg",
                            Diet = "Vegan, Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 Slices of Bread"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 scoops peanut butter."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3 scoop strawberry jelly."
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Get peanut butter and jelly."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Make sandwich."
                                }
                            }
                        }
                        ,new Recipe
                        {
                            Title = "Butter Beer",
                            Description = "a caramel delight from the wizarding world right into your belly.",
                            PrepTime = "10 minutes",
                            CookTime = "0 minutes",
                            Yields = "8 Servings",
                            ImagePath = "~/images/butterbeer.jpg",
                            Diet = "Vegan, Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 Liters of cream soda, chilled."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 tsp caramel extract."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 tsp butter extract."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup heavy whipping cream."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup butterscotch topping."
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup powdered sugar."
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "In large mixing bowl, whip heavy cream until it forms stiff peaks."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Add butterscotch topping and powdered sugar."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Mix the caramel and butter extracts with the cream soda and then pour the mixture into clear cups or mugs."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Top with butterscotch cream topping and enjoy!"
                                }
                            }
                        }
                        ,new Recipe
                        {
                            Title = "Treacle Tart",
                            Description = "One of Harry Potter's favorite dishes, " +
                            "treacle tart is a traditional English pastry with a sugary filling that's often " +
                            "topped off with a serving of clotted cream. Or you can serve with a scoop of ice cream. We won't judge. ",
                            PrepTime = "10 minutes",
                            CookTime = "35 minutes",
                            Yields = "8 servings",
                            ImagePath = "~/images/treacle.jpg",
                            Diet = "Vegan, Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (9 inch) pie crust pastry"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup golden syrup"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3/4 cup heavy cream"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup bread crumbs"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 lemon, zested"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons lemon juice"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Preheat oven to 375 degrees F (190 degrees C). Press the pie crust pastry evenly into the bottom of a 9-inch pie plate."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Mix the syrup, cream, bread crumbs, lemon zest, and lemon juice together in a bowl; pour into the pie crust."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Bake in the preheated oven until the filling is set, 35 to 40 minutes. Allow to cool slightly before serving."
                                }
                            }
                        }
                        ,new Recipe
                        {
                            Title = "Cornish Pasties",
                            Description = "These perfectly flaky and golden pastries are stuffed with beef, " +
                            "pork, and root vegetables for a hearty dish. One bite will" +
                            " transport you to the Three Broomsticks Inn in Hogsmeade. ",
                            PrepTime = "15 minutes",
                            CookTime = "45 minutes",
                            Yields = "12 pasties",
                            ImagePath = "~/images/cornishPasties.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="4 cups all-purpose flour"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon salt"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups lard"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup cold water"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3 tablespoons vegetable oil"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 onion, finely diced"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="5 carrots, diced (Optional)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 rutabagas, diced"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 pound lean ground beef"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 pound ground pork"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="10 green onions, chopped"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="salt and pepper to taste"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup butter"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons milk"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "To Make Crust: Place flour and salt in a large bowl." +
                                    " Mix well, then cut in lard until mixture is crumbly. Stir in water, mixing just " +
                                    "until dough forms a ball. Allow dough to rest in refrigerator while you make filling."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "To Make Filling: Heat a large skillet over medium-high heat. " +
                                    "Add vegetable oil, then onions. If using carrots and rutabagas, add them now. " +
                                    "Saute vegetables until soft, about 10 minutes."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Add ground beef, ground pork, and green onions to skillet. " +
                                    "Saute until meat is no longer pink. Add salt and pepper to taste. Preheat the oven to 400 degrees F (200 degrees C)."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Divide dough into 12 portions and roll out each one to fit a" +
                                    " 9-inch pie plate."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "Place a pastry circle in a pie pan. " +
                                    "Fill one half of pan with meat filling. Dot with some of the butter or margarine. " +
                                    "Pat edge of crust with water, then fold over other half of crust. " +
                                    "Trim edge, then crimp to seal. Make steam vents in top of crust. Brush with milk." +
                                    " Repeat process until all of dough and all of filling are gone."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 6,
                                    StepInstructions = "Bake in preheated oven for 45 minutes or until crust is golden brown."
                                }
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Wizarding World Pumpkin Juice",
                            Description = "Refreshing whether you're riding the Hogwarts Express or just hanging out at home, " +
                            "pumpkin juice is a brightly colored beverage that's sure to be a hit with everyone in the family. " +
                            "This version has a base of canned pumpkin, which is sweetened and spiced before serving. ",
                            PrepTime = "45 minutes",
                            CookTime = "15 minutes",
                            Yields = "2 1/2 quarts",
                            ImagePath = "~/images/pumpkinJuice.jpg",
                            Diet = "Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 quarts apple cider, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (2 inch) piece fresh ginger, sliced"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cinnamon stick"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 teaspoon whole cloves"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup brown sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup honey"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (28 ounce) can pumpkin puree"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Stir 3 cups apple cider, ginger, cinnamon stick, and cloves together in a saucepan; " +
                                    "bring to a boil, reduce heat to low, and simmer until slightly reduced, about 15 minutes."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Remove saucepan from heat and immediately stir brown sugar and honey into the " +
                                    "cider mixture until dissolved into the liquid."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Pour the liquid into a wide glass dish and refrigerate until chilled completely, " +
                                    "at least 45 minutes."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Mix the chilled apple cider mixture with the remaining apple cider and the " +
                                    "pumpkin puree in a large pitcher; stir until the puree dissolves into the liquid."
                                }
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Lemon Drop Bark",
                            Description = "Albus Dumbledore adores lemon drop candy so much that it's used as " +
                            "his office password in Chamber of Secrets. Honor the Hogwarts Headmaster's sweet tooth " +
                            "with this brightly colored bark, decorated with crushed lemon drop candies. ",
                            PrepTime = "10 minutes",
                            CookTime = "32 minutes",
                            Yields = "12 servings",
                            ImagePath = "~/images/LDbark.jpg",
                            Diet = "Vegan, Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (12 ounce) package white chocolate chips (such as Nestle®)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3/4 cup lemon drop candies (such as Brach's)"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Place white chocolate chips in a microwave-safe 2-cup measuring cup; " +
                                    "heat in microwave until melted, about 2 minutes. Stir until smooth."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Place lemon drop candies in a resealable plastic bag." +
                                    " Place this bag into another resealable bag, creating a double bag so the candies " +
                                    "don't puncture the bag. Crack candies with rolling pin or mallet until broken into small pieces."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Stir cracked candies into melted white chocolate. " +
                                    "Smooth mixture onto a piece of aluminum foil to about 1/4-inch thickness. " +
                                    "Chill in refrigerator until set, at least 30 minutes. " +
                                    "Break bark into small pieces and store in an air-tight container in the refrigerator."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Butterbeer Sugar Cookies",
                            Description = "After a spring break trip to Universal Studios® Wizarding World of Harry Potter, " +
                            "I was feeling nostalgic and wanted to try my hand at making a butterbeer-flavored cookie. " +
                            "After a few test batches, this recipe was finally approved by my family of extremely picky " +
                            "Harry Potter fans as being the perfect cookie recreation: lightly butterscotchy, " +
                            "with vanilla and brown sugar accents, just like the Wizarding World drink!",
                            PrepTime = "20 minutes",
                            CookTime = "10 minutes",
                            Yields = "2 dozen cookies",
                            ImagePath = "~/images/bbcookies.jpg",
                            Diet = "Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="3/4 cup butter, cubed, at room temperature"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3/4 cup packed brown sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup white sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 large egg"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons maple syrup"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons sour cream"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 teaspoons vanilla butter and nut flavoring"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 teaspoon pumpkin pie spice"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 teaspoons baking soda"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups all-purpose flour"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons white sugar, or as needed"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Beat butter, brown sugar, and white sugar together" +
                                    " in a large bowl until creamy using an electric mixer. Add egg, maple syrup, sour cream, vanilla butter " +
                                    "and nut flavoring, and pumpkin pie spice. Beat again until combined. Add baking soda and slowly mix in flour," +
                                    " 1/2 cup at a time; dough will be sticky."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Chill dough in the refrigerator for 30 minutes."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Preheat the oven to 350 degrees F (175 degrees C)."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Pour 2 tablespoons white sugar into a shallow bowl. " +
                                    "Roll dough into walnut-sized balls using your hands, roll balls in sugar, " +
                                    "and place on an ungreased cookie sheet. Flatten each cookie slightly using your palm," +
                                    " and leave space between each, as cookies will spread during baking."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "Bake in the preheated oven until edges are golden brown, 8 to 10 minutes. Cool on a rack."
                                }
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Lemon Drop Bark",
                            Description = "Albus Dumbledore adores lemon drop candy so much that it's used as " +
                            "his office password in Chamber of Secrets. Honor the Hogwarts Headmaster's sweet tooth " +
                            "with this brightly colored bark, decorated with crushed lemon drop candies. ",
                            PrepTime = "10 minutes",
                            CookTime = "32 minutes",
                            Yields = "12 servings",
                            ImagePath = "~/images/LDbark.jpg",
                            Diet = "Vegan, Vegetarian",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (12 ounce) package white chocolate chips (such as Nestle®)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3/4 cup lemon drop candies (such as Brach's)"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Place white chocolate chips in a microwave-safe 2-cup measuring cup; " +
                                    "heat in microwave until melted, about 2 minutes. Stir until smooth."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Place lemon drop candies in a resealable plastic bag." +
                                    " Place this bag into another resealable bag, creating a double bag so the candies " +
                                    "don't puncture the bag. Crack candies with rolling pin or mallet until broken into small pieces."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Stir cracked candies into melted white chocolate. " +
                                    "Smooth mixture onto a piece of aluminum foil to about 1/4-inch thickness. " +
                                    "Chill in refrigerator until set, at least 30 minutes. " +
                                    "Break bark into small pieces and store in an air-tight container in the refrigerator."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Spooky Calzone Snake",
                            Description = "Whether you're a Slytherin fan, or just want to recreate (spoiler alert!) " +
                            "the slaying of Nagini by Neville Longbottom, this calzone snake is sure to be the star of your spread. " +
                            "Serve with green pesto on the side for some Slytherin House pride. ",
                            PrepTime = "30 minutes",
                            CookTime = "35 minutes",
                            Yields = "14 servings",
                            ImagePath = "~/images/calzoneSnake.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon white sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup warm water (110 degrees F/45 degrees C)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (.25 ounce) package active dry yeast"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons olive oil"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 1/2 teaspoons kosher salt"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3 cups all-purpose flour, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup ricotta cheese"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups shredded mozzarella cheese"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup grated Parmesan cheese, or to taste"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (4 ounce) package sliced pepperoni"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 teaspoon Italian seasoning"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 tablespoon chopped fresh parsley"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup sliced black olives (Optional)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 green bell pepper, cut into strips (Optional)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup sliced fresh mushrooms (Optional)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 egg"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 tablespoon water"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Dissolve the sugar in the warm water in the bowl of a stand mixer fitted with a dough hook." +
                                    " Sprinkle the yeast over the water, and let stand for 5 minutes until the yeast softens and begins to form a " +
                                    "creamy foam. Stir in the oil, salt, and 2 cups of flour, and mix on Low until the mixture forms a wet dough." +
                                    " With the machine running, add 1 cup of flour, 1/4 cup at a time, and knead until the dough pulls away from the" +
                                    " sides of the bowl into a ball. Knead for 3 to 5 more minutes, until the dough is smooth and elastic."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Lightly oil a large bowl, then place the dough in the bowl and turn to coat with oil. " +
                                    "Cover with a light cloth and let rise in a warm place (80 to 95 degrees F (27 to 35 degrees C)) " +
                                    "until doubled in volume, about 1 hour."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Combine the ricotta, mozzarella, and Parmesan cheeses, pepperoni, parsley, " +
                                    "Italian seasoning, olives, green pepper, and mushrooms in a large bowl, and set aside."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Preheat oven to 375 degrees F (190 degrees C). Line a baking sheet with parchment paper."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "Punch down the dough, and roll it out into a long, flat strip about 9 inches wide " +
                                    "by 30 inches long. Spoon the filling mixture down the center of the dough strip, leaving about 1 inch on " +
                                    "all sides for sealing. Pull edges of the dough together; pinch to seal and form a long, filled roll. Place " +
                                    "the roll, seam side down, onto the parchment paper in a snakey 'S' shape, and tuck the ends underneath to seal." +
                                    " Beat the egg in a bowl with 1 tablespoon of water, and brush the egg wash over the calzone."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 6,
                                    StepInstructions = " Bake in the preheated oven for 30 to 35 minutes, until the calzone is golden brown." +
                                    " Let cool for 5 minutes before cutting into individual slices."
                                }
                            }
                        }

                });


                _ = context.SaveChanges();

            }
        }
    }
}
