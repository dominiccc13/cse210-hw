using System.ComponentModel;

class ChecklistGoal : Goal
{
    private int _completionsRequired;
    private int _timesCompleted;
    private int _bonusPoints;
    public override void NewGoal(string name, string desc, int points, bool status=false, int completionsRequired=10, int bonusPoints=500) {
        this._name = name;
        this._desc = desc;
        this._points = points;
        this._status = status;
        this._completionsRequired = completionsRequired;
        this._bonusPoints = bonusPoints;
    }
    public override void UpdateStatus(bool status=false) {
        this._timesCompleted += 1;
        this._totalPoints += this._points;
        this._status = false;
        if (this._completionsRequired < this._timesCompleted) {
            this._timesCompleted = 1;
            this._status = false;
        }
        if (this._completionsRequired == this._timesCompleted) {
            // this._timesCompleted = 0;
            this._status = true;
            this._totalPoints += _bonusPoints;
        }
        else this._status = false;
    }
    public override int GetTimesCompleted() {
        return _timesCompleted;
    }
    public override void RecordEvent() {
        UpdateStatus();
    }
    public override int GetCompletionsRequired() {
        return _completionsRequired;
    }
}