namespace Dependency_inversion
{
    /*
        Dependency inversion - prinsippet handler om å lage programvare på en måte som gjør det lettere å endre og vedlikeholde.
        Det er å skrive (om) kode slik at høynivåmoduler ikke avhenger direkte av lavnivåmoduler,
        men at begge er avhengige av abstraksjoner

        Dette kan gjøres ved å implementere abstraksjoner som grensesnitt (interface) eller abstrakte klasser.
        Dette tillater høynivåmoduler å avhenge av abstraksjoner i stedet for å avhenge direkte av lavnivåmoduler.
        Deretter implementeres disse abstraksjonene i de konkrete klassene.
     */
        
    // Eksempel:
    // La oss si at du har en klasse som lagrer data i en fil:

    public class FileStorage1
    {
        public void SaveData(string data)
        {
            // Lagre data i en fil
        }
    }

    // Normalt ville du muligens brukt denne klassen direkte inni en annen klasse slik:

    public class DataManager1
    {
        private FileStorage1 _fileStorage;

        public DataManager1(FileStorage1 fileStorage)
        {
            _fileStorage = fileStorage;
        }

        public void ProcessData(string data)
        {
            // Logikk for å behandle data
            _fileStorage.SaveData(data);
        }
    }

    // Med Dependency Inversion vil du i stedet lage et grensesnitt eller en abstraksjon.
    // Her er et eksempel med et Interface:

    public interface IDataStorage
    {
        void SaveData(string data);
    }

    // Deretter endrer du FileStorage for å implementere interfacet:
    public class FileStorage : IDataStorage
    {
        public void SaveData(string data)
        {
            // Lagre data i en fil
        }
    }

    // Til slutt endrer du DataManager for å bruke interfacet istedenfor den andre klassen:
    public class DataManager
    {
        private IDataStorage _dataStorage;

        public DataManager(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        public void ProcessData(string data)
        {
            // Logikk for å behandle data
            _dataStorage.SaveData(data);
        }
    }

    /*
        Med denne metoden kan du enkelt endre måten dataen lagres på (for eksempel fra fil til database),
        med å lage en annen klasse som implementerer IDataStorage, men DataManager-klassen trenger ikke å endres.

        Med denne metoden er det lettere å teste, utvide og endre koden,
        samt lettere å endre eller erstatte deler av koden uten at høy-nivå-delene blir påvirket.
     */



}
