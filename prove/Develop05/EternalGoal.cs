using System.Drawing;

class EternalGoal : Goal {
    public override void NewGoal(string name, string desc, int points, bool status=false, int completionsRequired=0, int bonusPoints=0) {
        this._name = name;
        this._desc = desc;
        this._points = points;
    }
    public override void UpdateStatus(bool status=false)
    {
        // string doNothing = "do nothing";
        this._status = false;
        this._totalPoints += this._points;
    }
    public override void RecordEvent() {
        UpdateStatus();
        this._totalPoints += this._points;
    }
}