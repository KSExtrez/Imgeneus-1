﻿using Imgeneus.Database.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Imgeneus.Database.Preload
{
    /// <inheritdoc />
    public class DatabasePreloader : IDatabasePreloader
    {
        private readonly ILogger<DatabasePreloader> _logger;
        private readonly IDatabase _database;

        /// <inheritdoc />
        public Dictionary<(byte Type, byte TypeId), DbItem> Items { get; private set; } = new Dictionary<(byte Type, byte TypeId), DbItem>();

        /// <inheritdoc />
        public Dictionary<(ushort SkillId, byte SkillLevel), DbSkill> Skills { get; private set; } = new Dictionary<(ushort SkillId, byte SkillLevel), DbSkill>();

        public DatabasePreloader(ILogger<DatabasePreloader> logger, IDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        /// <inheritdoc />
        public void Preload()
        {
            try
            {
                PreloadItems(_database);
                PreloadSkills(_database);

                _logger.LogInformation("Database was successfully preloaded.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during preloading database: {ex.Message}");
            }

        }

        /// <summary>
        /// Preloads all available items from database.
        /// </summary>
        private void PreloadItems(IDatabase database)
        {
            var items = database.Items;
            foreach (var item in items)
            {
                Items.Add((item.Type, item.TypeId), item);
            }
        }

        /// <summary>
        /// Preloads all available skills from database.
        /// </summary>
        private void PreloadSkills(IDatabase database)
        {
            var skills = database.Skills;
            foreach (var skill in skills)
            {
                Skills.Add((skill.SkillId, skill.SkillLevel), skill);
            }
        }
    }
}
