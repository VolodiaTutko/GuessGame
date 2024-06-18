using GuessGame.Data;
using GuessGame.Data.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GuessGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //AddWordList();
            Application.Run(new Forms.StartUp());
           
        }

        static void AddWordList()
        {
            try
            {

                using (var context = new AppDbContext())
                {

                    var wordList = new List<Word> {
                new Word {Value = "������", Description = "���������� ��� �������, ��� ��������� �� ���������� � ����� ������."},
                new Word {Value = "˳����", Description = "������, ��� ������ � ��, ������� �� �������� �� ���� ������������ ��������."},
                new Word {Value = "������", Description = "����������� ������� � ������� ����������, �� ���� ����������� ��� ���������."},
                new Word {Value = "������", Description = "������, ��� ����������� ����� ��� ���������� ��� ��������� ������ �� ����� �����."},
                new Word {Value = "Գ����", Description = "Գ���� ������ ��� ����������, ��������� �� �������� ������'� �� ������� �����."},
                new Word {Value = "������", Description = "��������� ����� ��� ����������� �������� ������� �� ������."},
                new Word {Value = "������", Description = "������ ������ � �������� ���������, ��� ����� ��������������� �� �������� �� г����."},
                new Word {Value = "������", Description = "������ ������ � ������� ���������, �������� � ������� ������� ������ ���� �� �������."},
                new Word {Value = "Գ����", Description = "�����, �� ����� ������� ����� �� �� �������."},
                new Word {Value = "������", Description = "������, ��� �������� ������ ��� ������ �� ���������� ��� �������."},
                new Word {Value = "�����", Description = "������� ������ ��� ����������� ��������� ����� �� ��� ���������."},
                new Word {Value = "������", Description = "����� �  ���������� ���������,����������� � �������� �'����� ��������� �������"},
                new Word {Value = "������", Description = "����������� ������, �� ������� ������, ����, �������, ��������� �� ��."},
                new Word {Value = "������", Description = "��� ���������, �� ���������� � �������� ����� ��� �� ������."},
                new Word {Value = "������", Description = "���������, �� ������ ������, �������, ���� �� �����."},
                new Word {Value = "������", Description = "��������� ��� ������, �� �� �������, ���������� �� ������� �'��� � ������ ���������."},
                new Word {Value = "������", Description = "J�������� �������� �� ������, �������� �� ������ ����, �������� �� ������� ���������."},
                new Word {Value = "������", Description = "����������, ����� �� �����, �� ������ ������� ����� ��������, ���������� ��� ��������."},
                new Word {Value = "������", Description = "���� �����, �� ���� �� ������� � ������ �'������, ��������� ���� � ���������� ���� �����."},
                new Word {Value = "������", Description = "������� ����, �� ������� ���������� �������� ��� ���� �������� �������� ������ ������� ����."}

                };
                    foreach (var word in wordList)
                    {
                        context.Words.Add(word);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� �������� �����: {ex.Message}");
            }

        }
    }
}