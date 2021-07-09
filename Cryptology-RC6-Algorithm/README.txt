-------------------------------RC6 ŞİFRELEME ALGORİTMASI-----------------------------------

Ron Rivest, Matt Robshaw, Ray Sidney ve Yiqun Lisa Yin tarafından 1998 yılında RC5 şifrelemesinin bir uzantısı olarak geliştirilen AES yarışmasının finalisti olan bir kriptoloji yöntemidir.Anahtar boyutu 128, 192 veya 256 bit olabilir.Blok boyutu 128 bit kadardır.Yapısal olarak basit, hızlı ve günümüzde halen güvenli olarak düşünülmektedir.

////////////////////////////////// PROGRAMIN TANIMI /////////////////////////////////////

C# diliyle yazılmış, dışarıdan alınan key, plaintext ve ciphertext değerlerine göre gerekli işlemleri yapan, kullanıcıya girdiği text verisine uygulanan encryption ve decryption işlemlerinin sonuçlarını döndüren bir programdır.

////////////////////////////// PROGRAMDA YAPILAN İŞLEMLER/////////////////////////////////

Word size of bits : w = 32 (lg(w)=5)
Number of rounds : r = 20
Number of key bytes : b = 16,24,32


1.RC6'da her biri 32 bitlik 44 alt anahtar kullanılır.

2.Şifrelenecek blok 4 adet 32 bitlik tamsayıya çevrilir(A,B,C,D).

3.İlk 4 bayt A olur.

4.B, S[0] ile; D, S[1] ile XOR işlemine girer.

5.Her turda iki adet alt anahtar kullanılır.

6.Bir tur:
   B'nin f(x)=x(2x+1) fonksiyonuna girdikten sonra çıkan sonucu sola 5 bit  döndürülür ve elde edilen sonuç A ile XOR işlemine girer.
   D'nin aynı f(x) fonksiyonuna girdikten sonra çıkan sonucu sola 5 bit döndürülür ve elde edilen sonuç C ile XOR işlemine girer.
   A ile XOR işlemine giren değerin en az öneme sahip 5 biti C'nin dairesel sola kayma miktarını belirler.
   C ile XOR işlemine giren değerin en az öneme sahip 5 biti A'nin dairesel sola kayma miktarını belirler.
   Daha sonra turun ilk alt anahtarı A ile, ikinci alt anahtarı C ile XOR işlemine girer.
   Sonra bloğun dört çeyreği şu şekilde döndürülür:
	A'nın değeri D'ye,
	B'nin değeri A'ya,
	C'nin değeri B'ye,
	D'nin değeri C'ye yerleştirilir.

7.20. tur tamamlanınca A S[42] ile, C S[43] ile XOR işlemine girer.


/////////////////////////////////////// ÖNEMLİ ////////////////////////////////////////

Programda çalışılan karakterler kümesi ---> {a,b,c,d,e,f}
Programda çalışılan sayısal değeler kümesi ---> {0,1,2,3,4,5,6,7,8,9}
Key, plaintext ve ciphertext 32, 64, vb. sayıda karakter girilmelidir.






