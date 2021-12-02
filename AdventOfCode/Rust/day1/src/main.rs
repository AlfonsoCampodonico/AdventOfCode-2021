fn count_increase(measurements: &Vec<u32>, distance: usize) -> u32 {
    let mut increases = 0;
    for i in distance..measurements.len() {
        if measurements.get(i - distance) < measurements.get(i) {
            increases += 1
        }
    }
    increases
}

let result1 = count_increase(&input, 1);
println!("Found {} increases", result1);
let result2 = count_increase(&input, 3);
println!("Found {} triple increases", result2);