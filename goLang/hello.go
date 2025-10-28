package main

import "fmt"

func main(){
	fmt.Println("Hello People")

	var flag bool = true

	var i int = 145;
	var i8 int8 = 12
	var i16 int16 = 125
	var i32 int32 = 1258
	var i64 int64 = 12585

	var ui uint = 145;
	var u8 uint8 = 124
	var u16 uint16 = 1997
	var u32 uint32 = 1395937
	var u64 uint64 = 139425937

	var f32 float32 = 52.68
	var f64 float64 = 48.25

	var str string = "Rizu is my Love!"
	var r rune = 'A'

	fmt.Println("Boolean", flag);
	fmt.Println("8 bit signed integer", i8);
	fmt.Println(i,i16,i32,i64,ui,u8,u16,u32,u64,f32,f64,str,r);
}