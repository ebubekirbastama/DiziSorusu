# 🧩 Dizi Sorusu

**Dizi Sorusu**, C# ile dizi (array), string arama ve `Substring` işlemlerini göstermek amacıyla hazırlanmış küçük bir Windows Forms örnek projesidir.

Uygulama, bir şiir dizisindeki her satırda `söz` kelimesinin konumunu bulur ve daha sonra bu konuma kadar olan metni başka bir listeye aktarır. Kaynak kodu doğrudan bu iki işlemi demonstrasyon amacıyla gerçekleştirir. fileciteturn218file0

## ✨ Ne Öğretiyor?

- C# `string[]` dizi kullanımı
- `for` döngüsü
- `IndexOf()` ile metin içinde kelime arama
- Bulunan karakter indeksini kullanma
- `Substring()` ile metnin belirli bölümünü alma
- `ListBox` kontrolüne veri ekleme
- Windows Forms event handling

## 🧠 Çalışma Mantığı

Uygulamada dört satırlık bir şiir dizisi bulunur. İlk buton çalıştırıldığında her satır için:

```csharp
poem[i].IndexOf("söz")
```

ifadesi kullanılarak `söz` kelimesinin başlangıç konumu bulunur.

İkinci buton ise bulunan indeksleri kullanarak:

```csharp
poem[i].Substring(0, sayi)
```

ile ilgili satırın başlangıç bölümünü alır ve sabit bir metinle birleştirerek ikinci listeye ekler. fileciteturn218file0

## 📂 Proje Yapısı

```text
DiziSorusu/
│
├── Dizi Sorusu.sln
├── .gitignore
├── .gitattributes
│
└── Dizi Sorusu/
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    └── Properties/
```

## ▶️ Kullanım

1. Projeyi Visual Studio ile açın.
2. Uygulamayı çalıştırın.
3. İlk butona basarak `söz` kelimesinin dizinin her elemanındaki indekslerini görüntüleyin.
4. İkinci butona basarak bu indekslere göre oluşturulan metinleri ikinci listede görüntüleyin.

## ⚙️ Kurulum

### Gereksinimler

- Windows
- Visual Studio
- C# / .NET Framework ile uyumlu Windows Forms geliştirme ortamı

Repoyu klonlamak için:

```bash
git clone https://github.com/ebubekirbastama/DiziSorusu.git
```

Ardından `Dizi Sorusu.sln` dosyasını Visual Studio ile açıp çalıştırabilirsiniz.

## ⚠️ Teknik Not

Kaynak kodunda örnek amaçlı sabit bir web adresi (`www.ebubekirbastama.com`) kullanılmaktadır. Bu değer gerçek bir uygulamada yapılandırılabilir bir değişken veya kullanıcı girdisi haline getirilebilir.

Ayrıca ikinci buton, ilk buton tarafından oluşturulan `listBox1` verilerine ihtiyaç duyar. Bu nedenle normal kullanım sırası **önce birinci, sonra ikinci buton** şeklindedir.

## 🚀 Geliştirme Fikirleri

- Kullanıcının kendi metnini girebilmesi
- Aranacak kelimenin TextBox üzerinden belirlenmesi
- Bulunamayan kelimeler için daha anlaşılır sonuç gösterilmesi
- `IndexOf` sonucunun doğrudan `int` olarak tutulması
- `Substring` işlemleri için sınır kontrolleri eklenmesi
- Sonuçların DataGridView üzerinde daha düzenli gösterilmesi

## 📄 Lisans

Bu repository içerisinde ayrı bir lisans dosyası bulunmuyorsa, kodu yeniden dağıtmadan önce proje sahibiyle kullanım koşullarını netleştirmeniz önerilir.

## 👨‍💻 Geliştirici

**Ebubekir Baştama**

GitHub: https://github.com/ebubekirbastama
