var i8: Int8 = 114;
var i16: Int16=542;
var i32: Int32=245425;
var i64: Int64=6895899852;
var i: Int = 3654; // Platform-sized (32-bit for 32-bit platform, 64-bit for 64-bit platform)

var u: UInt = 3654; // Platform-sized (32-bit for 32-bit platform, 64-bit for 64-bit platform)
var u8: UInt8 = 100;
var u16: UInt16 = 500;
var u32: UInt32=985;
var u64: UInt64=88525474;

var f: Float = 2.42; // Float
var d: Double = 2.9652;
var flag: Bool = true;
var char: Character = "A";
var s: String = "Maruf";
var name: String? = nil;

print("8 bit signed integer", i8);
print("16 bit signed integer", i16);
print("32 bit signed integer", i32);
print("64 bit signed integer", i64);
print("Platform sized signed integer", i);

print("8 bit unsigned integer", u8);
print("16 bit unsigned integer", u16);
print("32 bit unsigned integer", u32);
print("64 bit unsigned integer", u64);
print("Platform sized unsigned integer", u);

print("Float",f)
print("Double",d)
print("Boolean",flag)
print("Character",char)
print("String",s)
print("Null",name as Any)