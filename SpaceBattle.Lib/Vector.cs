namespace SpaceBattle.Lib;
using System;
 ﻿public class Vector{
    public int size = 0;
    public int[] vec;        
    public Vector(params int[] args){
        size = args.Length;
        vec = args;
    }
    public int this[int i]{
        get {
            return vec[i];
        }
    }
    public override string ToString(){  
        string s = "Vector(";
        for (int i = 0; i < size - 1; i++) {
            s +=($"{vec[i]}, ");
        }
        s += ($"{vec[size - 1]})");
        return s;
    }
    public static Vector operator + (Vector v1, Vector v2){
        if (v1.size != v2.size) {
            throw new System.ArgumentException();
        }
        else{
            int[] sum = new int[v1.size];
            for (int i = 0; i < v1.size; i++) {
                sum[i] = v1[i] + v2[i];
            }
            return new Vector(sum);
        }
    }
    public static Vector operator - (Vector v1, Vector v2){
        if (v1.size != v2.size) {
            throw new System.ArgumentException();
        }
        else {
            int[] min = new int[v1.size];
            for (int i = 0; i < v1.size; i++) {
                min[i] = v1[i] - v2[i];
            }
            return new Vector(min);
        }
    }
    public static Vector operator * (int m, Vector v1){
        int[] pr = new int[v1.size];
        for (int i = 0; i < v1.size; i++) {
            pr[i] = v1[i] * m;
        }
        return new Vector(pr);
    }
    public static bool operator == (Vector v1, Vector v2){
        if (v1.size != v2.size)
            return false;
        bool flag = true;
        for (int i = 0; i < v1.size; i++) {
            if (v1[i] != v2[i]) {
                flag = false;
                break;
            }  
        }
        return flag;
    }
    public static bool operator != (Vector v1, Vector v2){
        return !(v1 == v2);
    }
    public static bool operator < (Vector v1, Vector v2){
        if (v1.size > v2.size) {
            return false;
        }
        if (v1 == v2)
            return false;
        for (int i = 0; i < v1.size; i++) {
            if (v1[i] > v2[i]) return false;
        }
        return true;
    }
    public static bool operator > (Vector v1, Vector v2){
        if (v1.size < v2.size) {
            return false;
        }
        if (v1 == v2)
            return false;
        for (int i = 0; i < v1.size; i++) {
            if (v1[i] < v2[i]) return false;
        }
        return true;
    }
    public override bool Equals(object? obj) { 
        if (ReferenceEquals(obj, null)) return false;
        if (ReferenceEquals(this, obj)) return true;
        throw new NotImplementedException();
    }
    public override int GetHashCode() {
        return HashCode.Combine(vec);
    }
}
