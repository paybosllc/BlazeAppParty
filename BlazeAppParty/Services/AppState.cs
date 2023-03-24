using Microsoft.AspNetCore.Components;

namespace BlazeAppParty.Services {
    public class AppState {

        private string? message;

        public string Message {
            get => message ?? "Initial Message";
            set {
                message = value;
                NotifyStateChanged();
            }
        }

        private int teamAScore = 0;
        public int TeamAScore {
            get => teamAScore;
            set {
                teamAScore = value;
                NotifyStateChanged();
            }
        }

        private int teamBScore = 0;
        public int TeamBScore {
            get => teamBScore;
            set {
                teamBScore = value;
                NotifyStateChanged();
            }
        }

        private int questions = 6;
        public int Questions {
            get => questions;
            set {
                questions = value;
                NotifyStateChanged();
            }
        }

        private List<string> categories = new() { "Title 1", "Title 2", "Title 3", "Title 4", "Title 5", "Title 6" };
        public List<string> Categories {
            get => categories;
            set {
                categories = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
