/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [Decorates a weapon with attachments and changes the weapons firing rate, range, stength, and cooldown]
 */

public class WeaponDecorator : IWeapon
{
    //the decorated weapon that gets passed to the weapon decorator
    private readonly IWeapon _decoratedWeapon;

    //an attachment that gets passed to the weapon decorator
    private readonly WeaponAttachment _attachment;

    /// <summary>
    /// Decorates a weapon with a passed in weapon and attachement
    /// </summary>
    /// <param name="weapon"> the weapon to decorate </param>
    /// <param name="attachment"> the attachment to decorate the weapon with </param>
    public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
    {
        //set the local attachement and weapon to the attachment and weapon that is passed into the weapon decorator
        _attachment = attachment;
        _decoratedWeapon = weapon;
    }

    //applies the attachments firing rate change to the weapon
    public float FiringRate
    {
        get { return _decoratedWeapon.FiringRate + _attachment.FiringRate; }
    }

    //applies the attachments range change to the weapon
    public float Range
    {
        get { return _decoratedWeapon.Range + _attachment.Range; }
    }

    //applies the attachments strength change to the weapon
    public float Strength
    {
        get { return _decoratedWeapon.Strength + _attachment.Strength; }
    }

    //applies the attachments cooldown change to the weapon
    public float Cooldown
    {
        get { return _decoratedWeapon.Cooldown + _attachment.Cooldown; }
    }
}
