use std::io;

fn main(
    println!("Kérem az A értékét:");
    let mut read_line = String::new();
    io::stdin().readline(&mut read_line).expect("Failed to read line!");
    let A : f64 = read_line.trim().parse();
    io::stdin().readline(&mut read_line).expect("Failed to read line!");
    let B : f64 = read_line.trim().parse();

    let sugar = Math.Sqrt((A*A)+(B*B))/2;
    println!(&"A kör sugara: {}",sugar);
)