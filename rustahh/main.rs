use std::io;

fn main() {
    Koszones();
}

fn Koszones() {
    println!("Szia");
}

fn Feladat01(){
    println!("Input: ");
    let mut line : String = String::new();
    std::io::stdin().read_line(&mut line);

    println!("You entered: {}",line);
}