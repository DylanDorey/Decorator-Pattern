/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [A weapon interface that must implement a Range, FiringRate, Strength, and Cooldown property]
 */

public interface IWeapon
{
    float Range { get; }
    float FiringRate { get; }
    float Strength { get; }
    float Cooldown { get; }
}
