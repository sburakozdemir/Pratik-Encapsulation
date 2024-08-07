# Pratik-Encapsulation

Bu proje, C# programlama dilinde nesne yönelimli programlama (OOP) prensiplerinden biri olan kapsülleme (encapsulation) kavramını uygulamalı olarak göstermektedir.

## Proje Açıklaması

Bu projede, `Car` (Araba) sınıfı oluşturulmuştur. Bu sınıf, bir arabanın temel özelliklerini (marka, model, renk, kapı sayısı) içerir ve özellikle kapı sayısı özelliği için kapsülleme uygulanmıştır.

### Özellikler

- **Marka (Brand)**: Arabanın markası
- **Model**: Arabanın modeli
- **Renk (Color)**: Arabanın rengi
- **Kapı Sayısı (DoorCount)**: Arabanın kapı sayısı (2 veya 4 olmalıdır)

## Önemli Özellikler

1. **Kapsülleme**: `DoorCount` özelliği, sadece 2 veya 4 değerlerini kabul eder. Diğer değerler girildiğinde bir hata mesajı görüntülenir ve değer -1 olarak ayarlanır.

2. **Bilgi Gösterimi**: `InfoCar()` metodu, arabanın tüm özelliklerini konsolda gösterir.
