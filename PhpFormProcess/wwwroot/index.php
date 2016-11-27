<?php
$connect = mysql_connect("eu-cdbr-azure-north-e.cloudapp.net","baefb5e94ee8b1","8a553dfc") or die("MySql Baglantisi Saglanamadi.");
mysql_select_db("halicdb") or die("Veritaban? Baglantisi Saglanamadi.");
//$conn = new mysqli($servername, $username, $password);
//mysql_select_db("halicdb");
//$servername = "eu-cdbr-azure-north-e.cloudapp.net";
//$username = "baefb5e94ee8b1";
//$password = "8a553dfc";
//if ($conn->connect_error) {
//    die("Connection failed: " . $conn->connect_error);
//}
    $ad = $_POST["username"];
    $soyad = $_POST["usersurname"];
    $mail = $_POST["usermail"];
    $kimlikno = $_POST["usertckimlikno"];
    $telefonno = $_POST["usertelno"];
    $il = $_POST["city"];
    $dogumtarih = $_POST["userbday"];
    $sifre = $_POST["sifre1"];

    $query = mysql_query('insert into users (User_Name,User_Surname,User_Mail,User_Tc_No,User_Phone,User_City,User_Date,User_Password)
values("'.$ad.'","'. $soyad.'","'.$mail.'","'.$kimlikno.'","'. $telefonno.'","'. $il.'","'.$dogumtarih.'","'.$sifre.'")');

    if($query)
    {
        echo 'Kayit Islemi Tamamlandi';
    }


    else
    {
        echo 'Ekleme Basarisiz.<br/>'.mysql_error();
        
    }
    $ask = mysql_query('select * from users');
    while($results = mysql_fetch_array($ask))
    {
        echo '<br/>Kullanici Adi :'.$results['User_Name'].'<br/>Email Adresi : '.$results['User_Mail'];
    }
?>

   




//if($_POST){

//    // Formdan Gelen Kay?tlar
//    $ad        =    $_POST["username"];
//    $soyad    =    $_POST["usersurname"];
//    $mail = $_POST["usermail"];
//    $kimlikno = $_POST["usertckimlikno"];
//    $telefonno = $_POST["usertelno"];
//    $il = $_POST["city"];
//    $dogumtarih = $_POST["userbday"];
//    $sifre = $_POST["sifre1"];
//    $sifretekrar = $_POST["sifre2"];
//    $ekle =  mysql_query("insert into users (username,usersurname,usermail,usertckimlikno,usertelno,city,userbday,sifre1,sifre2) values ('$User_Name','$User_Surname','$User_Mail','$User_Tc_No', '$User_Phone','$User_City','$User_Date','$User_Password','$User_PassRepeat')");

//}
?>