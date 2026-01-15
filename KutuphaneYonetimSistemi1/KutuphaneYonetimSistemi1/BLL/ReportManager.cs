using System;
using System.Data;
using MySql.Data.MySqlClient;
using KutuphaneYonetimSistemi1.DAL; // DbHelper buradaysa

public class ReportManager
{
    DbHelper db = new DbHelper();

    // 1. LİSTE: İADE BEKLEYEN KİTAPLAR
    public DataTable GetPendingReturns()
    {
        string query = @"
            SELECT 
                b.id as 'Kitap ID',
                b.title AS 'Kitap Adı', 
                m.first_name AS 'Üye Adı', 
                m.last_name AS 'Üye Soyadı', 
                br.borrow_date AS 'Alış Tarihi'
            FROM borrows br
            JOIN books b ON br.book_id = b.id
            JOIN members m ON br.member_id = m.id
            WHERE br.is_returned = 0 
            ORDER BY br.borrow_date ASC";

        // DÜZELTİLEN YER: ExecuteQuery -> GetDataTable
        return db.GetDataTable(query);
    }

    // 2. LİSTE: TÜM HAREKET GEÇMİŞİ
    public DataTable GetAllTransactionHistory()
    {
        string query = @"
            SELECT 
                br.id AS 'İşlem No',
                b.title AS 'Kitap Adı',
                m.first_name AS 'Üye Adı', 
                m.last_name AS 'Üye Soyadı',
                br.borrow_date AS 'Alış Tarihi',
                CASE 
                    WHEN br.is_returned = 1 THEN 'TESLİM EDİLDİ' 
                    ELSE 'BEKLİYOR' 
                END AS 'Durum'
            FROM borrows br
            JOIN books b ON br.book_id = b.id
            JOIN members m ON br.member_id = m.id
            ORDER BY br.borrow_date DESC";

        // DÜZELTİLEN YER: ExecuteQuery -> GetDataTable
        return db.GetDataTable(query);
    }
}