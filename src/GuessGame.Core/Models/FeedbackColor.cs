namespace GuessGame.Core.Models;

public enum FeedbackColor
{
    Green,   // doğru rakam + doğru pozisyon
    Blue,    // rakam doğru, pozisyon yanlış
    Yellow,  // rakam var ama tahminde fazladan kullanıldı
    Red      // rakam hiç yok
}

