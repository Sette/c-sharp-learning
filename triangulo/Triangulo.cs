using System;


namespace triangulo {
class Triangulo {
    private double a, b, c;

    public void setA(double a){
        this.a = a;

    }   

    public void setB(double b){
        this.b = b;
        
    } 

    public void setC(double c){
        this.c = c;
        
    } 

    public double area() {
        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    }
}