/***********************************************************************
* file: ArrayPrint.cs
* author: Ivan Trinh
* class: CS 4700 - Game Development
* assignment: Program 1
* date last modified: 9/07/2024
*
* purpose: This program's main goal is to prove that I have installed
* Unity and know how to write a basic program in C#. This script takes
* a hard-coded 2D array and prints it out in regular and reverse order,
* in addition to finding the minimum and maximum number in the array.
*
***********************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayPrint : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        int[,] array = {{1, 5, 6}, {4, 2, 0}, {3, 4, 5}};
        Print2DArray(array);
        ReversePrint2DArray(array);
        FindMax(array);
        FindMin(array);
    }

    // Update is called once per frame
    void Update(){
        
    }
    // Prints out a 2D array 
    void Print2DArray(int[,] numbers){
        string returnString = "Normal Order:\n";
        for (int i = 0; i < numbers.GetLength(0); i++){
            for (int j = 0; j < numbers.GetLength(1); j++){
                returnString = returnString + (numbers[i, j]) + "\t";
            }
            returnString = returnString + "\n";
        }
        print(returnString);
    }
    // Prints out a 2D array in reverse
    void ReversePrint2DArray(int[,] numbers){
        string returnString = "Reverse Order:\n";
        for (int i = numbers.GetLength(0)-1; i >= 0; i--){
            for (int j = numbers.GetLength(1)-1; j >= 0; j--){
                returnString = returnString + (numbers[i, j]) + "\t";
            }
            returnString = returnString + "\n";
        }
        print(returnString);
    }
    // Finds the largest value in a 2D array
    void FindMax(int[,] numbers){
        string returnString = "Maximum: ";
        int max = numbers [0, 0];
        for (int i = 0; i < numbers.GetLength(0); i++){
            for (int j = 0; j < numbers.GetLength(1); j++){
                if (numbers[i, j] > max)
                    max = numbers[i, j];
            }
        }
        returnString = returnString + max;
        print(returnString);
    }
    // Finds the smallest value in a 2D array
    void FindMin(int[,] numbers){
        string returnString = "Minimum: ";
        int min = numbers [0, 0];
        for (int i = 0; i < numbers.GetLength(0); i++){
            for (int j = 0; j < numbers.GetLength(1); j++){
                if (numbers[i, j] < min)
                    min = numbers[i, j];
            }
        }
        returnString = returnString + min;
        print(returnString);
    }
}

