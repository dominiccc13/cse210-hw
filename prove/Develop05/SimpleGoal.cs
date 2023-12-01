using System.ComponentModel;

class SimpleGoal : Goal
{
    public override void NewGoal(string name, string desc, int points, bool status=false, int completionsRequired=0, int bonusPoints=0) {
        this._name = name;
        this._desc = desc;
        this._points = points;
        this._status = status;
    }
    public override void UpdateStatus(bool status=false) {
        this._status = true;
        this._totalPoints += this._points;
    }
    public override void RecordEvent() {
        UpdateStatus();
    }
}