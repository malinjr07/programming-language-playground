// statically typed

fn main() {
    // Signed
    let sByte: i8 = 127; // 8-bit integer
    let sShort: i16 = 142; // 16-bit integer
    let sInt: i32 = 148; // 32-bit integer
    let sLInt: i64 = 18521; // 64-bit integer
    let sDLInt: i128 = 164684; // 128-bit integer

    // Un-signed
    let uByte: u8 = 145; // 8-bit integer
    let uShort: u16 = 2415; // 16-bit integer
    let uInt: u32 = 96523; // 32-bit integer
    let ulInt: u64 = 56146487; // 64-bit integer
    let uDLInt: u128 = 54616351136; // 128-bit integer

    let flt: f32 = 25.1452; // Float
    let dlft: f64 = 52.1482522; // Double Float
    let c: char = 'A'; // char
    let flag: bool = true; // Boolean

    let tupl: (i32, bool) = (421, true);
    let arr: [i32; 5] = [1, 8, 5, 4, 6];
    let strs = String::from("Amazon");

    println!("sByte: {}", sByte);
    println!("sShort: {}", sShort);
    println!("sInt: {}", sInt);
    println!("sLInt: {}", sLInt);
    println!("sDLInt: {}", sDLInt);
    println!("uByte: {}", uByte);
    println!("uShort: {}", uShort);
    println!("uInt: {}", uInt);
    println!("ulInt: {}", ulInt);
    println!("uDLInt: {}", uDLInt);
    println!("flt: {}", flt);
    println!("dlft: {}", dlft);
    println!("char: {}", c);
    println!("flag: {}", flag);
    println!("tupl: {:?}", tupl);
    println!("arr: {:?}", arr);
    println!("strs: {}", strs);
}
