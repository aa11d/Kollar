use std::io;

fn main(
    println!("Kérem az A értékét:");
    let mut read_line = String::new();
    io::stdin().readline(&mut read_line).expect("Failed to read line!");
    let m : f64 = read_line.trim().parse();
    io::stdin().readline(&mut read_line).expect("Failed to read line!");
    let s : f64 = read_line.trim().parse();

    if m/s > 5 {
        println!("Lomha")
    }
    else{
        if m/s == 5 {
            println!("Fürge")
        }
        else{
            if m/s < 5 {
                println!("Lassú")
            }
        }
    }
)