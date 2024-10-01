// SortedList koleksiyonu  : Sıralı liste koleksiyonu

// SortedList, bugüne kadar gördüğümüz koleksiyonlardan, farklı olarak Key ve Value çifti taşırlar

// Syntax : 

using System.Collections;

SortedList sortedList = new SortedList();
sortedList.Add(9,"Ali");
sortedList.Add(6,"Hande");
sortedList.Add(1,"Elif");
sortedList.Add(7,"Selçuk");

//  Keğeri Uniq olmalıdır. Eğer koleksiyon içerisinde olan bir key değerini girerseniz, Derleme zamanı hatası değilde, çalışma zamanı hatası alırsınız.
sortedList.Add(7,"Handan");

// SortedList koleksiyonu, key ve value değerini, object tipinden alır.
// object tipinde aldığı için, değeri int yada string girebiliriz.

// Sortedlist, adından da anlaşılacağı üzere, girilen key değerlerine göre, sıralama işlemi yapar.
// verileri karışık girseniz bile, hiç müdahale etmeden, key değerine göre sıralar.
// key değeri eğer sayısal bir değerse, küçükten büyüğe doğru, harf ise, alfabetik sıra ile sıralayacaktır.
// SortedList ekrana yazdırma
/*for(int i=0;i<sortedList.Count;i++){

    // GetByIndex fonksiyonu ile , sortedlist koleksiyonunu ekranda gösterdik
    string value = sortedList.GetByIndex(i).ToString();
    Console.WriteLine(value);
}*/

// Key ve Value taşıdığı için Contais(Arama) fonksiyonu iki tanedir.
// ContainsKey ve ContainsValue fonksiyonları key arama ve value arama için kullanılır.

// Örnek : 

bool isContainsKey = sortedList.ContainsKey(90);
Console.WriteLine(isContainsKey);

bool isContainsValue = sortedList.ContainsValue("Elif");
Console.WriteLine(isContainsValue);


