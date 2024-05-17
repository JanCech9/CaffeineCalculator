function calculateCaffeine() {
    const espressoMl = document.getElementById('espresso').value;
    const filterCoffeeMl = document.getElementById('filterCoffee').value;
    
    // Caffeine content: approximately 64 mg per 30 ml of espresso and 14 mg per 30 ml of filter coffee
    const caffeineEspresso = (espressoMl / 30) * 64;
    const caffeineFilterCoffee = (filterCoffeeMl / 30) * 14;
    const totalCaffeine = caffeineEspresso + caffeineFilterCoffee;

    document.getElementById('result').textContent = `Total Caffeine Content: ${totalCaffeine.toFixed(2)} mg`;
}