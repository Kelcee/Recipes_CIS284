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
                       ,new Recipe
                        {
                            Title = "Cockroach Clusters",
                            Description = "A Honeydukes specialty and Weasley boys' favorite, chocolatey cockroach clusters " +
                            "are bite-sized treats that are perfect for tricking friends into eating bugs. Our version is a bit " +
                            "more tame, substituting peanuts for roaches. ",
                            PrepTime = "10 minutes",
                            CookTime = "5 minutes",
                            Yields = "3 dozen",
                            ImagePath = "~/images/cockroachClusters.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (12 ounce) package semi-sweet chocolate chips"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (12 ounce) package peanut butter chips"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="12 ounces raw Spanish peanuts"
                                },
                               
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Combine chocolate chips and peanut butter chips in top of double boiler. " +
                                    "Stir frequently over low to medium heat until melted; add peanuts and stir."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Drop by teaspoon full on wax paper. Allow to cool."
                                },                               
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Adult Butterbeer",
                            Description = "Although the butterbeer in the books isn't alcoholic, " +
                            "that shouldn't stop you from splashing a little booze in your next batch." +
                            " Here, spiced rum and butterscotch schnapps add deep flavor with a kick. ",
                            PrepTime = "5 minutes",
                            CookTime = "5 minutes",
                            Yields = "1 serving",
                            ImagePath = "~/images/adultBeer.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 fluid ounce spiced rum (such as Sailor Jerry)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 fluid ounce butterscotch schnapps"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 teaspoon imitation butter flavoring"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (12 fluid ounce) can or bottle cream soda"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 small scoop vanilla ice cream (Optional)"
                                },

                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Stir rum and butterscotch schnapps together in a frosted 14-ounce mug."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Pour butter flavoring into the cream soda, then turn cream soda over to pour " +
                                    "quickly into the chilled mug. Gently drop the ice cream into the soda mixture."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Magic Wands",
                            Description = "You won't have to trek to Ollivanders Wand Shop to get yourself a magical wand." +
                            " Instead, create a custom wand by dipping pretzels in chocolate and decorating with " +
                            "sprinkles and candy.",
                            PrepTime = "30 minutes",
                            CookTime = "30 minutes",
                            Yields = "30 servings",
                            ImagePath = "~/images/magicWands.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (15 ounce) package pretzel rods"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (16 ounce) container prepared vanilla frosting"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup sprinkles or colored sugar for decoration"
                                },                          

                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Dip each pretzel rod into frosting, not quite half way. " +
                                    "Roll in sprinkles to coat the frosting. Abracadabra, you have a magic wand!"
                                },                               
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Acceptance Letters",
                            Description = "Flavored with lemon and orange zest, these dainty folded cookies are the perfect recreation of the Hogwarts acceptance letters.",
                            PrepTime = "25 minutes",
                            CookTime = "8 minutes",
                            Yields = "4 dozen",
                            ImagePath = "~/images/letters.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups all-purpose flour"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="½ cup white sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon salt"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup butter"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 teaspoons lemon zest"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 tablespoon orange zest"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup sour cream"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup candied cherries, chopped"
                                },

                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Preheat oven to 475 degrees F (245 degrees C)."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Blend flour, sugar and salt. Cut in butter, lemon zest and orange zest until mixture resembles coarse meal. Blend sour cream in evenly."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Gather dough into firm ball. Divide in half. Roll on well-floured surface to 1/8 inch thickness. Cut in 3 x 2 inch pieces; fold ends to center to resemble an envelope, overlapping slightly; seal with tiny piece of candied cherry."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Place on ungreased baking sheet. Brush tops with water; sprinkle with sugar. Bake 6 to 8 minutes."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Harry's Birthday Cake",
                            Description = " Although the book version of Harry's 11th birthday describes a chocolate cake, any movie-goer remembers the bright pink version that was presented by Hagrid in the film. Recreate that iconic dessert with a batch of sweet strawberry cake.",
                            PrepTime = "30 minutes",
                            CookTime = "1 Hour",
                            Yields = "12 servings",
                            ImagePath = "~/images/harrysCake.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (3 ounce) package strawberry flavored Jell-O"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="½ cup cold water"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (18.25 ounce) package white cake mix"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="4 eggs"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup vegetable oil"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3 tablespoons all-purpose flour"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (10 ounce) package frozen strawberries, thawed"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="6 tablespoons butter"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups confectioners' sugar"
                                },

                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Preheat the oven to 325 degrees F (165 degrees C). Grease and flour three 9 inch round cake pans."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "In a large bowl, dissolve the gelatin in cold water; stir in the cake mix, eggs, vegetable oil, flour and 1/2 of the strawberries. Beat for 5 minutes on the medium speed of an electric mixer. Divide the batter evenly between the prepared cake pans."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Bake for 30 to 35 minutes in the preheated oven, or until the layers spring back when lightly pressed in the center. Cool cakes in the pans on wire racks."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "To Make Frosting: Cream the butter, sugar and the remaining half of the strawberries in a medium bowl until light and fluffy, adding additional confectioners' sugar if needed for a spreadable consistency. Spread the frosting between layers and over the top and sides of cake."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Owl Cupcakes",
                            Description = "Ever useful in the wizarding world, owls play a key part in the entire Harry Potter series. Recreate their wide-eyed look with these adorable owl cupcakes. Sandwich cookies and candy coated chocolates are cleverly used to make the features. ",
                            PrepTime = "30 minutes",
                            CookTime = "12 minutes",
                            Yields = "24 servings",
                            ImagePath = "~/images/owls.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups white sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups all-purpose flour, sifted"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup unsweetened cocoa powder"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 teaspoons baking powder"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon salt"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 teaspoon baking soda"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup buttermilk"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup vegetable oil"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 eggs"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon vanilla extract"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup hot water"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup heavy whipping cream"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 1/2 tablespoons heavy whipping cream"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 1/2 cups mascarpone cheese"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="7 tablespoons unsweetened cocoa powder"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup white sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="48 chocolate sandwich cookies (such as Oreo)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="48 brown candy-coated milk chocolate pieces (such as M&M's)"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="24 orange or yellow candy-coated milk chocolate pieces (such as M&M's)"
                                },

                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Preheat oven to 350 degrees F (175 degrees C). Line 2 muffin tins with paper liners."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Combine 2 cups sugar, flour, 1 cup cocoa powder, baking powder, salt, and baking soda in a bowl."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Whisk buttermilk, vegetable oil, eggs, and vanilla extract in a large bowl. Add flour mixture; mix until well-combined. Pour in hot water; stir until batter is smooth. Divide batter evenly among muffin tins."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 12 minutes. Transfer cupcakes to a wire rack and let cool completely, about 20 minutes."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "Whip 3/4 cup plus 1 1/2 tablespoon heavy cream in a bowl with an electric mixer until soft peaks form. Fold in 1 1/2 cup plus 2 tablespoons mascarpone cheese, 7 tablespoons cocoa powder, and 1/4 cup sugar gently to make frosting."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 6,
                                    StepInstructions = "Spread 1 tablespoon frosting over each cooled cupcake."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 7,
                                    StepInstructions = "Twist chocolate sandwich cookies open, leaving all cream filling on 1 side. Place 2 cookies, cream filling-side up, on each cupcake to make owl eyes. Place a brown milk chocolate piece on each cookie to create pupils. Insert an orange or yellow milk chocolate piece in the center to make a beak."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Pretzel Broomstick",
                            Description = "Although they're no Nimbus 2000, these bite-size broomsticks will make an adorable addition to your snack table. Several reviewers suggested using chives to make the tie extra easy.",
                            PrepTime = "10 minutes",
                            CookTime = "10 minutes",
                            Yields = "12 servings",
                            ImagePath = "~/images/brooms.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="4 string cheese sticks, or more as needed"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="12 pretzel sticks"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 leaf fresh spinach, cut into strips, or more as needed"
                                },                               
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Cut each string cheese stick into thirds. Snip the ends of each third into thin strings to look like a broom."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Place a pretzel stick into each piece of string cheese to create the broom handle. Tie a spinach strip around the cheese."
                                },                                
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Chocolate Spiders",
                            Description = "Ron Weasley's worst fear, these chocolatey spiders will please even the biggest arachnophobe. Chow mein noodles are tossed with chocolate confectioners coating before being decorated with candy eyes. ",
                            PrepTime = "5 minutes",
                            CookTime = "25 minutes",
                            Yields = "20 servings",
                            ImagePath = "~/images/chocSpiders.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 pound chocolate confectioners' coating"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 (8.5 ounce) package chow mein noodles"
                                },                               
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Chop the chocolate confectioners' coating and place into a heatproof bowl over simmering water. " +
                                    "Cook, stirring occasionally until melted and smooth. Remove from heat and stir in the chow mein noodles so they are evenly distributed." +
                                    " Spoon out to desired size onto waxed paper. Let cool completely before storing or serving."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Chocolate Spiders",
                            Description = "Feel like you’re in potions class with this bewitching beverage. For a nonalcoholic version, just omit the vodka.",
                            PrepTime = "5 minutes",
                            CookTime = "no minutes",
                            Yields = "20 servings",
                            ImagePath = "~/images/witchesBrew.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup water"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="8 medium kiwifruit, peeled and quartered"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup fresh mint leaves"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup vodka, optional"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 liter ginger ale, chilled"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="Ice cubes"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "In a small saucepan, bring sugar and water to a boil. Cook and stir until sugar is dissolved; set aside to cool."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Place the kiwi, mint and sugar syrup in a blender; cover and process until blended. Pour into a large pitcher; stir in vodka if desired. Refrigerate until chilled."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Just before serving, stir in ginger ale. Serve over ice."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Wingless Snitches",
                            Description = "These eggnog-flavored snitches are so good, you’ll feel like you’ve won a Quidditch game with each bite.",
                            PrepTime = "45 minutes",
                            CookTime = "no minutes",
                            Yields = "2 1/2 dozen",
                            ImagePath = "~/images/snitches.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="3-1/2 cups white baking chips, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup butter, softened"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="3 ounces cream cheese, softened"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons dark rum"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 teaspoon vanilla extract"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 tablespoons shortening"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="Ground nutmeg, optional"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "In a microwave, melt 1-1/2 cups baking chips; stir until smooth. In a small bowl, cream butter and cream cheese until smooth. Add rum and vanilla. Beat in melted chips. Refrigerate, covered, 1 hour or until set."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Shape mixture into 1-in. balls; place on a waxed paper-lined baking sheet. Refrigerate 2 hours or until firm and slightly dry to the touch."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "In a microwave, melt shortening and remaining baking chips; stir until smooth. Dip balls in mixture; allow excess to drip off. Return to baking sheet; if desired, sprinkle with nutmeg."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Refrigerate 2 hours or until set. Store between layers of waxed paper in an airtight container in the refrigerator."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Hogwarts Hats",
                            Description = "These eggnog-flavored snitches are so good, you’ll feel like you’ve won a Quidditch game with each bite.",
                            PrepTime = "50 minutes",
                            CookTime = "10 minutes",
                            Yields = "16 servings",
                            ImagePath = "~/images/hats.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 tube (16-1/2 ounces) refrigerated sugar cookie dough"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup baking cocoa"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup Corn Pops"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup bite-sized Shredded Wheat"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup square oat cereal"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup dried cherries"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup salted pumpkin seeds or pepitas, optional"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/3 cup butter, cubed"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups semisweet chocolate chips, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1-1/3 cups confectioners' sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 tablespoon shortening"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="16 ice cream sugar cones"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="Orange and green sprinkles"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Preheat oven to 350°. Let cookie dough stand at room temperature for 5-10 minutes to soften. In a large bowl, beat cookie dough and cocoa until blended. Shape into 1-1/2-in. balls; place 3 in. apart on ungreased baking sheets. Coat bottom of a glass with cooking spray. Press cookies with bottom of glass to flatten, recoating in cooking spray as needed."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Bake 10-12 minutes or until set. Cool completely on pans on wire racks."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "In a large bowl, combine corn pops, Shredded Wheat, oat cereal, cherries and, if desired, pumpkin seeds. In a microwave, melt butter and 1/2 cup chocolate chips; stir until smooth. Pour over cereal mixture; toss to coat."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Place confectioners' sugar in a large resealable plastic bag; add cereal mixture. Close bag and shake to coat. Spread onto baking sheets to cool."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "In a microwave, melt shortening and remaining chocolate chips; stir until smooth. Spread over sugar cones. Freeze until set, about 10 minutes. Fill each cone with 2 tablespoons cereal mixture."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 6,
                                    StepInstructions = "Place a filled cone on each cookie; pipe melted chocolate around base of cones to adhere. Decorate as desired with sprinkles and remaining melted chocolate. Refrigerate until set, about 10 minutes. Serve with remaining cereal mixtur"
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Polyjuice Potion",
                            Description = "While the real polyjuice potion takes a month (and a few human hairs) to brew, this deliciously sweet version takes moments to make. ",
                            PrepTime = "10 minutes",
                            CookTime = "0 minutes",
                            Yields = "20 servings",
                            ImagePath = "~/images/potions.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 quarts water"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 cups sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 envelopes unsweetened lemon-lime soft drink mix"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 can (46 ounces) unsweetened pineapple juice"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 liter ginger ale, chilled"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 quart lime sherbet"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "In a punch bowl, combine the water, sugar and soft drink mix; stir until dissolved. Stir in pineapple juice. Refrigerate until chilled. Just before serving, stir in ginger ale and top with scoops of sherbet."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Dumbledore's Sherbet Lemon",
                            Description = "Dumbledore loved this sweet-tart treat so much, “sherbet lemon” was the password to his office!",
                            PrepTime = "25 minutes",
                            CookTime = "10 minutes",
                            Yields = "1 1/2 pounds",
                            ImagePath = "~/images/lemon.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="2 envelopes unflavored gelatin"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1-1/4 cups water, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2-1/4 cups sugar, divided"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2 packages (3 ounces each) lemon gelatin"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/2 cup lemon juice"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1 teaspoon grated lemon zest"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/4 cup clear edible glitter"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Line an 8-inch square pan with foil and spray foil with cooking spray; set aside."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "In a small bowl, sprinkle unflavored gelatin over 1/3 cup water; set aside."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "In a small saucepan, combine 2 cups sugar and remaining water. Bring to a boil over medium heat. Cook and stir until the sugar dissolves. Cook, without stirring, until candy thermometer reads 260° (hard-ball stage). Remove from the heat."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 4,
                                    StepInstructions = "Stir lemon gelatin and unflavored gelatin mixture into hot syrup; stir until sugar dissolves. Stir in lemon juice and zest. Pour into prepared pan. Cover and refrigerate overnight or until candy is set."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 5,
                                    StepInstructions = "Combine edible glitter and remaining sugar; spread half of mixture over a 14x12-in. piece of paper. Invert candy onto the parchment. Cut candy into 48 triangles and coat with remaining glitter mixture. Store candy in an airtight container at room temperature for up to 1 week."
                                },
                            }
                        }
                       ,new Recipe
                        {
                            Title = "Acid Pops",
                            Description = "While the Honeydukes version of lollipops can burn a hole in your tongue, ours are certified Muggle safe.",
                            PrepTime = "5 minutes",
                            CookTime = "30 minutes",
                            Yields = "1 dozen",
                            ImagePath = "~/images/lolli.jpg",
                            Diet = "none",
                            Ingredients = new List<RecipeIngredient>
                            {
                                new RecipeIngredient
                                {
                                    Ingredient ="1 cup light corn syrup"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="2/3 cup sugar"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1-1/2 teaspoons lemon, apple or cherry flavoring"
                                },
                                new RecipeIngredient
                                {
                                    Ingredient ="1/8 teaspoon yellow, green or red liquid food coloring"
                                },
                            },
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Place lollipop sticks in hard candy molds or arrange sticks 3 in. apart on greased foil-lined baking sheets; set aside."
                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "In a heavy saucepan, combine corn syrup and sugar. Bring to a boil over medium heat, stirring occasionally. Cover and cook for 3 minutes to dissolve sugar crystals. Uncover and cook over medium-high heat, without stirring, until a candy thermometer reads 300° (hard-crack stage)."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 3,
                                    StepInstructions = "Remove from the heat; stir in flavoring and food coloring, keeping face away from mixture as odor is very strong. Immediately pour into prepared molds or pour free-form over ends of lollipop sticks on baking sheets. Let cool before removing."
                                },
                            }
                        }
                });


                _ = context.SaveChanges();

            }
        }
    }
}
