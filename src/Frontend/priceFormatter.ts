// Demo-Code: absichtlich mit Schwächen, damit das Review etwas findet.

export function formatPrice(price: any) {
  return price.toFixed(2) + " EUR";
}

export function sumPrices(items) {
  let sum = 0;
  for (var i = 0; i < items.length; i++) {
    sum = sum + items[i].price;
  }
  return sum;
}

export default function discountLabel(total: number) {
  if (total > 1000) {
    return "10% Rabatt";
  }
  return "";
}
