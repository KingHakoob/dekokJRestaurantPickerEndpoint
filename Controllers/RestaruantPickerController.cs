// Jacob Dekok
// 10/26/2022
// Restaruant Picker API
// Picks a random restaruant out of three categories
// Peer Reviewed By: Jessie Lamzon
// Code is working very well and super clean code.
// I liked how you added the option to show available types with input.  Good job!


using Microsoft.AspNetCore.Mvc;

namespace dekokJRestaruantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaruantPickerController : ControllerBase
{
    [HttpGet]
    [Route("Restaruant/{restaruantType}")]

    public string RestaurantPicker(string restaruantType)
    {
        Random random = new Random();

        string[] fastFood = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes"};

        string[] delivery = {"Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys"};

        string[] dineIn = {"Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas", "Masumi", "Mikes Grill House",
    "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};

        string[] all = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes", "Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys", "Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas",
    "Masumi", "Mikes Grill House", "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};

        int fastFoodIndex = random.Next(fastFood.Length);
        int deliveryIndex = random.Next(delivery.Length);
        int dineInIndex = random.Next(dineIn.Length);
        int allIndex = random.Next(all.Length);

        if (restaruantType == "fastfood") return fastFood[fastFoodIndex];
        if (restaruantType == "delivery") return delivery[deliveryIndex];
        if (restaruantType == "dinein") return dineIn[dineInIndex];
        if (restaruantType == "all") return all[allIndex];
        if (restaruantType == "WhatAreMyOptions") return "Your options are: 'fastfood' 'delivery' 'dinein' 'all'";
        else return "Not a valid restaruant type";
    }
}
